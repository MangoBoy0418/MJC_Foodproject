﻿namespace MJC_Foodproject
{
    partial class Form12
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
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Controls.Add(button2, 0, 1);
            tableLayoutPanel1.Controls.Add(button3, 0, 2);
            tableLayoutPanel1.Controls.Add(button4, 0, 3);
            tableLayoutPanel1.Controls.Add(button5, 0, 4);
            tableLayoutPanel1.Controls.Add(button6, 0, 5);
            tableLayoutPanel1.Location = new Point(0, 54);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.Size = new Size(534, 452);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(528, 69);
            button1.TabIndex = 0;
            button1.Text = "스테이크";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button2.Location = new Point(3, 78);
            button2.Name = "button2";
            button2.Size = new Size(528, 69);
            button2.TabIndex = 1;
            button2.Text = "버팔로윙";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button3.Location = new Point(3, 153);
            button3.Name = "button3";
            button3.Size = new Size(528, 69);
            button3.TabIndex = 2;
            button3.Text = "치킨";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button4.Location = new Point(3, 228);
            button4.Name = "button4";
            button4.Size = new Size(528, 69);
            button4.TabIndex = 3;
            button4.Text = "케밥";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button5.Location = new Point(3, 303);
            button5.Name = "button5";
            button5.Size = new Size(528, 69);
            button5.TabIndex = 4;
            button5.Text = "라자냐";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button6.Location = new Point(3, 378);
            button6.Name = "button6";
            button6.Size = new Size(528, 71);
            button6.TabIndex = 5;
            button6.Text = "햄버거";
            button6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(85, 9);
            label1.Name = "label1";
            label1.Size = new Size(370, 47);
            label1.TabIndex = 2;
            label1.Text = "이 음식을 추천합니다!";
            // 
            // Form12
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 511);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            MaximumSize = new Size(550, 550);
            MinimumSize = new Size(550, 550);
            Name = "Form12";
            Text = "Form12";
            Load += Form12_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label1;
    }
}