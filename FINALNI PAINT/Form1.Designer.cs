namespace PAINT_FINAL
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Colors = new System.Windows.Forms.Button();
            this.Pen = new System.Windows.Forms.Button();
            this.Eraser = new System.Windows.Forms.Button();
            this.EraseAll = new System.Windows.Forms.Button();
            this.Background = new System.Windows.Forms.Button();
            this.AddImage = new System.Windows.Forms.Button();
            this.NewCanvas = new System.Windows.Forms.Button();
            this.Thickness = new System.Windows.Forms.TrackBar();
            this.Ellipse = new System.Windows.Forms.RadioButton();
            this.Rectangle = new System.Windows.Forms.RadioButton();
            this.Line = new System.Windows.Forms.RadioButton();
            this.Triangle = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.Thickness)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1486, 750);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // Colors
            // 
            this.Colors.Location = new System.Drawing.Point(26, 12);
            this.Colors.Name = "Colors";
            this.Colors.Size = new System.Drawing.Size(75, 45);
            this.Colors.TabIndex = 1;
            this.Colors.Text = "Colors";
            this.Colors.UseVisualStyleBackColor = true;
            this.Colors.Click += new System.EventHandler(this.Colors_Click);
            // 
            // Pen
            // 
            this.Pen.Location = new System.Drawing.Point(137, 12);
            this.Pen.Name = "Pen";
            this.Pen.Size = new System.Drawing.Size(75, 23);
            this.Pen.TabIndex = 2;
            this.Pen.Text = "Pen";
            this.Pen.UseVisualStyleBackColor = true;
            this.Pen.Click += new System.EventHandler(this.Pen_Click);
            // 
            // Eraser
            // 
            this.Eraser.Location = new System.Drawing.Point(137, 41);
            this.Eraser.Name = "Eraser";
            this.Eraser.Size = new System.Drawing.Size(75, 23);
            this.Eraser.TabIndex = 3;
            this.Eraser.Text = "Eraser";
            this.Eraser.UseVisualStyleBackColor = true;
            this.Eraser.Click += new System.EventHandler(this.Eraser_Click);
            // 
            // EraseAll
            // 
            this.EraseAll.Location = new System.Drawing.Point(218, 12);
            this.EraseAll.Name = "EraseAll";
            this.EraseAll.Size = new System.Drawing.Size(75, 23);
            this.EraseAll.TabIndex = 4;
            this.EraseAll.Text = "Erase all";
            this.EraseAll.UseVisualStyleBackColor = true;
            this.EraseAll.Click += new System.EventHandler(this.EraseAll_Click);
            // 
            // Background
            // 
            this.Background.Location = new System.Drawing.Point(218, 41);
            this.Background.Name = "Background";
            this.Background.Size = new System.Drawing.Size(75, 23);
            this.Background.TabIndex = 5;
            this.Background.Text = "Background";
            this.Background.UseVisualStyleBackColor = true;
            this.Background.Click += new System.EventHandler(this.Background_Click);
            // 
            // AddImage
            // 
            this.AddImage.Location = new System.Drawing.Point(461, 12);
            this.AddImage.Name = "AddImage";
            this.AddImage.Size = new System.Drawing.Size(75, 23);
            this.AddImage.TabIndex = 6;
            this.AddImage.Text = "Add Image";
            this.AddImage.UseVisualStyleBackColor = true;
            this.AddImage.Click += new System.EventHandler(this.AddImage_Click);
            // 
            // NewCanvas
            // 
            this.NewCanvas.Location = new System.Drawing.Point(461, 41);
            this.NewCanvas.Name = "NewCanvas";
            this.NewCanvas.Size = new System.Drawing.Size(75, 23);
            this.NewCanvas.TabIndex = 7;
            this.NewCanvas.Text = "new canvas";
            this.NewCanvas.UseVisualStyleBackColor = true;
            this.NewCanvas.Click += new System.EventHandler(this.NewCanvas_Click);
            // 
            // Thickness
            // 
            this.Thickness.Location = new System.Drawing.Point(308, 26);
            this.Thickness.Name = "Thickness";
            this.Thickness.Size = new System.Drawing.Size(133, 45);
            this.Thickness.TabIndex = 8;
            this.Thickness.Scroll += new System.EventHandler(this.Thickness_Scroll);
            // 
            // Ellipse
            // 
            this.Ellipse.AutoSize = true;
            this.Ellipse.Location = new System.Drawing.Point(559, 15);
            this.Ellipse.Name = "Ellipse";
            this.Ellipse.Size = new System.Drawing.Size(55, 17);
            this.Ellipse.TabIndex = 0;
            this.Ellipse.TabStop = true;
            this.Ellipse.Text = "Ellipse";
            this.Ellipse.UseVisualStyleBackColor = true;
            
            // 
            // Rectangle
            // 
            this.Rectangle.AutoSize = true;
            this.Rectangle.Location = new System.Drawing.Point(559, 47);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(74, 17);
            this.Rectangle.TabIndex = 10;
            this.Rectangle.TabStop = true;
            this.Rectangle.Text = "Rectangle";
            this.Rectangle.UseVisualStyleBackColor = true;
            
            // 
            // Line
            // 
            this.Line.AutoSize = true;
            this.Line.Location = new System.Drawing.Point(658, 18);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(45, 17);
            this.Line.TabIndex = 11;
            this.Line.TabStop = true;
            this.Line.Text = "Line";
            this.Line.UseVisualStyleBackColor = true;
            
            // 
            // Triangle
            // 
            this.Triangle.AutoSize = true;
            this.Triangle.Location = new System.Drawing.Point(658, 47);
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(63, 17);
            this.Triangle.TabIndex = 12;
            this.Triangle.TabStop = true;
            this.Triangle.Text = "Triangle";
            this.Triangle.UseVisualStyleBackColor = true;
            
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1486, 827);
            this.Controls.Add(this.Triangle);
            this.Controls.Add(this.Line);
            this.Controls.Add(this.Rectangle);
            this.Controls.Add(this.Ellipse);
            this.Controls.Add(this.Thickness);
            this.Controls.Add(this.NewCanvas);
            this.Controls.Add(this.Colors);
            this.Controls.Add(this.AddImage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Background);
            this.Controls.Add(this.Pen);
            this.Controls.Add(this.EraseAll);
            this.Controls.Add(this.Eraser);
            this.MaximumSize = new System.Drawing.Size(2000, 2000);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Thickness)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button NewCanvas;
        private System.Windows.Forms.Button AddImage;
        private System.Windows.Forms.Button Background;
        private System.Windows.Forms.Button EraseAll;
        private System.Windows.Forms.Button Colors;
        private System.Windows.Forms.Button Pen;
        private System.Windows.Forms.Button Eraser;
        private System.Windows.Forms.TrackBar Thickness;
        private System.Windows.Forms.RadioButton Ellipse;
        private System.Windows.Forms.RadioButton Rectangle;
        private System.Windows.Forms.RadioButton Line;
        private System.Windows.Forms.RadioButton Triangle;
    }
}

