using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GeometricShapes;

namespace ShapeDemoApp
{
    public partial class MainForm : Form
    {
        private Shape currentShape;

        private TextBox txtRadius;
        private Button btnCreateCircle;
        private TextBox txtSide;
        private Button btnCreateSquare;
        private TextBox txtWidth;
        private TextBox txtHeight;
        private Button btnCreateRectangle;
        private TextBox txtDeltaX;
        private TextBox txtDeltaY;
        private Button btnMove;
        private TextBox txtResizeFactor;
        private Button btnResize;
        private TextBox txtRotateAngle;
        private Button btnRotate;
        private Label lblShapeInfo;

        public MainForm()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents()
        {
            // txtRadius
            txtRadius = new TextBox
            {
                Location = new Point(20, 20),
                Name = "txtRadius",
                Size = new Size(100, 20)
            };
            this.Controls.Add(txtRadius);

            // btnCreateCircle
            btnCreateCircle = new Button
            {
                Location = new Point(130, 20),
                Name = "btnCreateCircle",
                Size = new Size(100, 20),
                Text = "Create Circle"
            };
            btnCreateCircle.Click += new EventHandler(btnCreateCircle_Click);
            this.Controls.Add(btnCreateCircle);

            // txtSide
            txtSide = new TextBox
            {
                Location = new Point(20, 60),
                Name = "txtSide",
                Size = new Size(100, 20)
            };
            this.Controls.Add(txtSide);

            // btnCreateSquare
            btnCreateSquare = new Button
            {
                Location = new Point(130, 60),
                Name = "btnCreateSquare",
                Size = new Size(100, 20),
                Text = "Create Square"
            };
            btnCreateSquare.Click += new EventHandler(btnCreateSquare_Click);
            this.Controls.Add(btnCreateSquare);

            // txtWidth
            txtWidth = new TextBox
            {
                Location = new Point(20, 100),
                Name = "txtWidth",
                Size = new Size(100, 20)
            };
            this.Controls.Add(txtWidth);

            // txtHeight
            txtHeight = new TextBox
            {
                Location = new Point(130, 100),
                Name = "txtHeight",
                Size = new Size(100, 20)
            };
            this.Controls.Add(txtHeight);

            // btnCreateRectangle
            btnCreateRectangle = new Button
            {
                Location = new Point(240, 100),
                Name = "btnCreateRectangle",
                Size = new Size(100, 20),
                Text = "Create Rectangle"
            };
            btnCreateRectangle.Click += new EventHandler(btnCreateRectangle_Click);
            this.Controls.Add(btnCreateRectangle);

            // txtDeltaX
            txtDeltaX = new TextBox
            {
                Location = new Point(20, 140),
                Name = "txtDeltaX",
                Size = new Size(100, 20)
            };
            this.Controls.Add(txtDeltaX);

            // txtDeltaY
            txtDeltaY = new TextBox
            {
                Location = new Point(130, 140),
                Name = "txtDeltaY",
                Size = new Size(100, 20)
            };
            this.Controls.Add(txtDeltaY);

            // btnMove
            btnMove = new Button
            {
                Location = new Point(240, 140),
                Name = "btnMove",
                Size = new Size(100, 20),
                Text = "Move"
            };
            btnMove.Click += new EventHandler(btnMove_Click);
            this.Controls.Add(btnMove);

            // txtResizeFactor
            txtResizeFactor = new TextBox
            {
                Location = new Point(20, 180),
                Name = "txtResizeFactor",
                Size = new Size(100, 20)
            };
            this.Controls.Add(txtResizeFactor);

            // btnResize
            btnResize = new Button
            {
                Location = new Point(130, 180),
                Name = "btnResize",
                Size = new Size(100, 20),
                Text = "Resize"
            };
            btnResize.Click += new EventHandler(btnResize_Click);
            this.Controls.Add(btnResize);

            // txtRotateAngle
            txtRotateAngle = new TextBox
            {
                Location = new Point(20, 220),
                Name = "txtRotateAngle",
                Size = new Size(100, 20)
            };
            this.Controls.Add(txtRotateAngle);

            // btnRotate
            btnRotate = new Button
            {
                Location = new Point(130, 220),
                Name = "btnRotate",
                Size = new Size(100, 20),
                Text = "Rotate"
            };
            btnRotate.Click += new EventHandler(btnRotate_Click);
            this.Controls.Add(btnRotate);

            // lblShapeInfo
            lblShapeInfo = new Label
            {
                Location = new Point(20, 260),
                Name = "lblShapeInfo",
                Size = new Size(320, 100),
                Text = "Shape Info"
            };
            this.Controls.Add(lblShapeInfo);
        }

        private void btnCreateCircle_Click(object sender, EventArgs e)
        {
            double radius = double.Parse(txtRadius.Text);
            currentShape = new Circle(radius);
            DisplayShapeInfo();
        }

        private void btnCreateSquare_Click(object sender, EventArgs e)
        {
            double side = double.Parse(txtSide.Text);
            currentShape = new Square(side);
            DisplayShapeInfo();
        }

        private void btnCreateRectangle_Click(object sender, EventArgs e)
        {
            double width = double.Parse(txtWidth.Text);
            double height = double.Parse(txtHeight.Text);
            currentShape = new Rectangle(width, height);
            DisplayShapeInfo();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            double deltaX = double.Parse(txtDeltaX.Text);
            double deltaY = double.Parse(txtDeltaY.Text);
            currentShape.Move(deltaX, deltaY);
            DisplayShapeInfo();
        }

        private void btnResize_Click(object sender, EventArgs e)
        {
            double factor = double.Parse(txtResizeFactor.Text);
            currentShape.Resize(factor);
            DisplayShapeInfo();
        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
            double angle = double.Parse(txtRotateAngle.Text);
            currentShape.Rotate(angle);
            DisplayShapeInfo();
        }

        private void DisplayShapeInfo()
        {
            lblShapeInfo.Text = $"Type: {currentShape.GetType().Name}\n" +
                                $"Position: ({currentShape.X}, {currentShape.Y})\n" +
                                $"Area: {currentShape.GetArea()}\n" +
                                $"Perimeter: {currentShape.GetPerimeter()}\n" +
                                $"Total Shapes Created: {Shape.ShapeCount}";
        }
    }
}
