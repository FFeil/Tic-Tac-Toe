using System.Windows.Forms;

namespace TicTacToe.GameApp
{
    partial class TicTacToeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label00 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.labelPlayer1 = new System.Windows.Forms.Label();
            this.label01 = new System.Windows.Forms.Label();
            this.label02 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPlayer2 = new System.Windows.Forms.Label();
            this.labelSymbol1 = new System.Windows.Forms.Label();
            this.labelSymbol2 = new System.Windows.Forms.Label();
            this.labelBot1 = new System.Windows.Forms.Label();
            this.labelBot2 = new System.Windows.Forms.Label();
            this.labelWinner1 = new System.Windows.Forms.Label();
            this.labelWinner2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(287, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "2 Player";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "1 Player";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label00
            // 
            this.label00.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label00.Location = new System.Drawing.Point(5, 2);
            this.label00.Name = "label00";
            this.label00.Size = new System.Drawing.Size(109, 115);
            this.label00.TabIndex = 3;
            this.label00.Text = "a";
            this.label00.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label00.Click += new System.EventHandler(this.label00_Click);
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(5, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 115);
            this.label10.TabIndex = 4;
            this.label10.Text = "a";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(5, 236);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(109, 116);
            this.label20.TabIndex = 5;
            this.label20.Text = "a";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(122, 236);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(109, 116);
            this.label21.TabIndex = 6;
            this.label21.Text = "a";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // labelPlayer1
            // 
            this.labelPlayer1.AutoSize = true;
            this.labelPlayer1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPlayer1.Location = new System.Drawing.Point(12, 419);
            this.labelPlayer1.Name = "labelPlayer1";
            this.labelPlayer1.Size = new System.Drawing.Size(91, 30);
            this.labelPlayer1.TabIndex = 13;
            this.labelPlayer1.Text = "Player 1:";
            // 
            // label01
            // 
            this.label01.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label01.Location = new System.Drawing.Point(122, 2);
            this.label01.Name = "label01";
            this.label01.Size = new System.Drawing.Size(109, 115);
            this.label01.TabIndex = 8;
            this.label01.Text = "a";
            this.label01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label01.Click += new System.EventHandler(this.label01_Click);
            // 
            // label02
            // 
            this.label02.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label02.Location = new System.Drawing.Point(239, 2);
            this.label02.Name = "label02";
            this.label02.Size = new System.Drawing.Size(111, 115);
            this.label02.TabIndex = 9;
            this.label02.Text = "a";
            this.label02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label02.Click += new System.EventHandler(this.label02_Click);
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(122, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 115);
            this.label11.TabIndex = 10;
            this.label11.Text = "a";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(239, 119);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 115);
            this.label12.TabIndex = 10;
            this.label12.Text = "a";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Webdings", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label22.Location = new System.Drawing.Point(239, 236);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(111, 116);
            this.label22.TabIndex = 11;
            this.label22.Text = "a";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(98, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 30);
            this.label1.TabIndex = 12;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPlayer2
            // 
            this.labelPlayer2.AutoSize = true;
            this.labelPlayer2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPlayer2.Location = new System.Drawing.Point(14, 462);
            this.labelPlayer2.Name = "labelPlayer2";
            this.labelPlayer2.Size = new System.Drawing.Size(91, 30);
            this.labelPlayer2.TabIndex = 14;
            this.labelPlayer2.Text = "Player 2:";
            // 
            // labelSymbol1
            // 
            this.labelSymbol1.AutoSize = true;
            this.labelSymbol1.Font = new System.Drawing.Font("Webdings", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSymbol1.Location = new System.Drawing.Point(104, 416);
            this.labelSymbol1.Name = "labelSymbol1";
            this.labelSymbol1.Size = new System.Drawing.Size(47, 33);
            this.labelSymbol1.TabIndex = 15;
            this.labelSymbol1.Text = "a";
            // 
            // labelSymbol2
            // 
            this.labelSymbol2.AutoSize = true;
            this.labelSymbol2.Font = new System.Drawing.Font("Webdings", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSymbol2.Location = new System.Drawing.Point(104, 462);
            this.labelSymbol2.Name = "labelSymbol2";
            this.labelSymbol2.Size = new System.Drawing.Size(47, 33);
            this.labelSymbol2.TabIndex = 16;
            this.labelSymbol2.Text = "a";
            // 
            // labelBot1
            // 
            this.labelBot1.AutoSize = true;
            this.labelBot1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBot1.Location = new System.Drawing.Point(157, 418);
            this.labelBot1.Name = "labelBot1";
            this.labelBot1.Size = new System.Drawing.Size(56, 30);
            this.labelBot1.TabIndex = 17;
            this.labelBot1.Text = "(Bot)";
            this.labelBot1.Visible = false;
            // 
            // labelBot2
            // 
            this.labelBot2.AutoSize = true;
            this.labelBot2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBot2.Location = new System.Drawing.Point(157, 462);
            this.labelBot2.Name = "labelBot2";
            this.labelBot2.Size = new System.Drawing.Size(56, 30);
            this.labelBot2.TabIndex = 18;
            this.labelBot2.Text = "(Bot)";
            this.labelBot2.Visible = false;
            // 
            // labelWinner1
            // 
            this.labelWinner1.AutoSize = true;
            this.labelWinner1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWinner1.Location = new System.Drawing.Point(277, 419);
            this.labelWinner1.Name = "labelWinner1";
            this.labelWinner1.Size = new System.Drawing.Size(80, 30);
            this.labelWinner1.TabIndex = 19;
            this.labelWinner1.Text = "Winner";
            this.labelWinner1.Visible = false;
            // 
            // labelWinner2
            // 
            this.labelWinner2.AutoSize = true;
            this.labelWinner2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelWinner2.Location = new System.Drawing.Point(277, 462);
            this.labelWinner2.Name = "labelWinner2";
            this.labelWinner2.Size = new System.Drawing.Size(80, 30);
            this.labelWinner2.TabIndex = 20;
            this.labelWinner2.Text = "Winner";
            this.labelWinner2.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.label00, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label01, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label02, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label11, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label12, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label20, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label21, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label22, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 59);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(355, 354);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(378, 504);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.labelWinner2);
            this.Controls.Add(this.labelWinner1);
            this.Controls.Add(this.labelBot2);
            this.Controls.Add(this.labelBot1);
            this.Controls.Add(this.labelSymbol2);
            this.Controls.Add(this.labelSymbol1);
            this.Controls.Add(this.labelPlayer2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPlayer1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button1;
        private Button button2;
        private Label label00;
        private Label label10;
        private Label label20;
        private Label label21;

        private Label label01;
        private Label label02;
        private Label label11;
        private Label label12;
        private Label label22;
        private Label label1;
        private Label labelPlayer1;
        private Label labelPlayer2;
        private Label labelSymbol1;
        private Label labelSymbol2;
        private Label labelBot1;
        private Label labelBot2;
        private Label labelWinner1;
        private Label labelWinner2;
        private TableLayoutPanel tableLayoutPanel1;
    }
}