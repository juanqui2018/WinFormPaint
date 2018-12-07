namespace juanCarlos.Paint
{
    partial class MiHijo
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
            this.pnl_Draw = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmb_PenSize = new System.Windows.Forms.ComboBox();
            this.btn_PenColor = new System.Windows.Forms.Button();
            this.txt_ShapeSize = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Square = new System.Windows.Forms.Button();
            this.btn_Rectangle = new System.Windows.Forms.Button();
            this.btn_Elipse = new System.Windows.Forms.Button();
            this.btn_Circle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.SfdFile = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_OpenFile = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Draw
            // 
            this.pnl_Draw.Location = new System.Drawing.Point(173, 12);
            this.pnl_Draw.Name = "pnl_Draw";
            this.pnl_Draw.Size = new System.Drawing.Size(868, 517);
            this.pnl_Draw.TabIndex = 0;
            this.pnl_Draw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Draw_MouseDown);
            this.pnl_Draw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_Draw_MouseMove);
            this.pnl_Draw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_Draw_MouseUp);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(75, 19);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(69, 62);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save File";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmb_PenSize
            // 
            this.cmb_PenSize.FormattingEnabled = true;
            this.cmb_PenSize.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cmb_PenSize.Location = new System.Drawing.Point(97, 26);
            this.cmb_PenSize.Name = "cmb_PenSize";
            this.cmb_PenSize.Size = new System.Drawing.Size(49, 21);
            this.cmb_PenSize.TabIndex = 1;
            this.cmb_PenSize.Text = "5";
            // 
            // btn_PenColor
            // 
            this.btn_PenColor.BackColor = System.Drawing.Color.Black;
            this.btn_PenColor.Location = new System.Drawing.Point(86, 59);
            this.btn_PenColor.Name = "btn_PenColor";
            this.btn_PenColor.Size = new System.Drawing.Size(60, 56);
            this.btn_PenColor.TabIndex = 2;
            this.btn_PenColor.UseVisualStyleBackColor = false;
            // 
            // txt_ShapeSize
            // 
            this.txt_ShapeSize.Location = new System.Drawing.Point(96, 25);
            this.txt_ShapeSize.Name = "txt_ShapeSize";
            this.txt_ShapeSize.Size = new System.Drawing.Size(48, 20);
            this.txt_ShapeSize.TabIndex = 3;
            this.txt_ShapeSize.Text = "10";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 56);
            this.button1.TabIndex = 4;
            this.button1.Text = "Change Color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Square
            // 
            this.btn_Square.Location = new System.Drawing.Point(9, 51);
            this.btn_Square.Name = "btn_Square";
            this.btn_Square.Size = new System.Drawing.Size(61, 56);
            this.btn_Square.TabIndex = 5;
            this.btn_Square.Text = "Fill Square";
            this.btn_Square.UseVisualStyleBackColor = true;
            this.btn_Square.Click += new System.EventHandler(this.btn_Square_Click);
            // 
            // btn_Rectangle
            // 
            this.btn_Rectangle.Location = new System.Drawing.Point(76, 51);
            this.btn_Rectangle.Name = "btn_Rectangle";
            this.btn_Rectangle.Size = new System.Drawing.Size(69, 56);
            this.btn_Rectangle.TabIndex = 6;
            this.btn_Rectangle.Text = "Fill Rectangle";
            this.btn_Rectangle.UseVisualStyleBackColor = true;
            this.btn_Rectangle.Click += new System.EventHandler(this.btn_Rectangle_Click);
            // 
            // btn_Elipse
            // 
            this.btn_Elipse.Location = new System.Drawing.Point(75, 113);
            this.btn_Elipse.Name = "btn_Elipse";
            this.btn_Elipse.Size = new System.Drawing.Size(69, 56);
            this.btn_Elipse.TabIndex = 8;
            this.btn_Elipse.Text = "Elipse";
            this.btn_Elipse.UseVisualStyleBackColor = true;
            this.btn_Elipse.Click += new System.EventHandler(this.btn_Elipse_Click);
            // 
            // btn_Circle
            // 
            this.btn_Circle.Location = new System.Drawing.Point(9, 113);
            this.btn_Circle.Name = "btn_Circle";
            this.btn_Circle.Size = new System.Drawing.Size(61, 56);
            this.btn_Circle.TabIndex = 7;
            this.btn_Circle.Text = "Fill Circle";
            this.btn_Circle.UseVisualStyleBackColor = true;
            this.btn_Circle.Click += new System.EventHandler(this.btn_Circle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Select Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Input Size";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmb_PenSize);
            this.groupBox1.Controls.Add(this.btn_PenColor);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 308);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 127);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pencil";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_ShapeSize);
            this.groupBox2.Controls.Add(this.btn_Square);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btn_Rectangle);
            this.groupBox2.Controls.Add(this.btn_Elipse);
            this.groupBox2.Controls.Add(this.btn_Circle);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(155, 184);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Shape";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_OpenFile
            // 
            this.btn_OpenFile.Location = new System.Drawing.Point(9, 19);
            this.btn_OpenFile.Name = "btn_OpenFile";
            this.btn_OpenFile.Size = new System.Drawing.Size(61, 62);
            this.btn_OpenFile.TabIndex = 1;
            this.btn_OpenFile.Text = "Open File";
            this.btn_OpenFile.UseVisualStyleBackColor = true;
            this.btn_OpenFile.Click += new System.EventHandler(this.btn_OpenFile_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.btn_OpenFile);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(155, 100);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Open/Save";
            // 
            // MiHijo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 541);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnl_Draw);
            this.Name = "MiHijo";
            this.Text = "MiHijo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Draw;
        private System.Windows.Forms.ComboBox cmb_PenSize;
        private System.Windows.Forms.Button btn_PenColor;
        private System.Windows.Forms.TextBox txt_ShapeSize;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Square;
        private System.Windows.Forms.Button btn_Rectangle;
        private System.Windows.Forms.Button btn_Elipse;
        private System.Windows.Forms.Button btn_Circle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog SfdFile;
        private System.Windows.Forms.Button btn_OpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}