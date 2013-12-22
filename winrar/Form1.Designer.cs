namespace winrar
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.filedir = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.selectdir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.exepath = new System.Windows.Forms.TextBox();
            this.selectexepath = new System.Windows.Forms.Button();
            this.smarkPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.selectsmarkPath = new System.Windows.Forms.Button();
            this.remarks = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.movefiledir = new System.Windows.Forms.TextBox();
            this.selectmovefiledir = new System.Windows.Forms.Button();
            this.slectmoveexepath = new System.Windows.Forms.Button();
            this.moveexepath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(487, 286);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 84);
            this.button1.TabIndex = 0;
            this.button1.Text = "开始";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // filedir
            // 
            this.filedir.Location = new System.Drawing.Point(132, 30);
            this.filedir.Margin = new System.Windows.Forms.Padding(5);
            this.filedir.Name = "filedir";
            this.filedir.Size = new System.Drawing.Size(342, 29);
            this.filedir.TabIndex = 1;
            this.filedir.Text = "C:\\Users\\Administrator\\Desktop\\1\\1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "来源路径";
            // 
            // selectdir
            // 
            this.selectdir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.selectdir.Location = new System.Drawing.Point(487, 20);
            this.selectdir.Margin = new System.Windows.Forms.Padding(5);
            this.selectdir.Name = "selectdir";
            this.selectdir.Size = new System.Drawing.Size(125, 40);
            this.selectdir.TabIndex = 3;
            this.selectdir.Text = "选择目录";
            this.selectdir.UseVisualStyleBackColor = true;
            this.selectdir.Click += new System.EventHandler(this.selectdir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "存放路径";
            // 
            // exepath
            // 
            this.exepath.Location = new System.Drawing.Point(132, 124);
            this.exepath.Margin = new System.Windows.Forms.Padding(5);
            this.exepath.Name = "exepath";
            this.exepath.Size = new System.Drawing.Size(342, 29);
            this.exepath.TabIndex = 5;
            this.exepath.Text = "C:\\Users\\Administrator\\Desktop\\1\\2";
            // 
            // selectexepath
            // 
            this.selectexepath.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.selectexepath.Location = new System.Drawing.Point(487, 121);
            this.selectexepath.Margin = new System.Windows.Forms.Padding(5);
            this.selectexepath.Name = "selectexepath";
            this.selectexepath.Size = new System.Drawing.Size(125, 40);
            this.selectexepath.TabIndex = 6;
            this.selectexepath.Text = "选择目录";
            this.selectexepath.UseVisualStyleBackColor = true;
            this.selectexepath.Click += new System.EventHandler(this.selectexepath_Click);
            // 
            // smarkPath
            // 
            this.smarkPath.Location = new System.Drawing.Point(132, 226);
            this.smarkPath.Margin = new System.Windows.Forms.Padding(5);
            this.smarkPath.Name = "smarkPath";
            this.smarkPath.Size = new System.Drawing.Size(342, 29);
            this.smarkPath.TabIndex = 8;
            this.smarkPath.Text = "C:\\Users\\Administrator\\Desktop\\1\\1.txt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 226);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "配置文件";
            // 
            // selectsmarkPath
            // 
            this.selectsmarkPath.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.selectsmarkPath.Location = new System.Drawing.Point(487, 223);
            this.selectsmarkPath.Margin = new System.Windows.Forms.Padding(5);
            this.selectsmarkPath.Name = "selectsmarkPath";
            this.selectsmarkPath.Size = new System.Drawing.Size(125, 40);
            this.selectsmarkPath.TabIndex = 10;
            this.selectsmarkPath.Text = "选择文件";
            this.selectsmarkPath.UseVisualStyleBackColor = true;
            this.selectsmarkPath.Click += new System.EventHandler(this.selectsmarkPath_Click);
            // 
            // remarks
            // 
            this.remarks.Location = new System.Drawing.Point(37, 286);
            this.remarks.Margin = new System.Windows.Forms.Padding(5);
            this.remarks.Multiline = true;
            this.remarks.Name = "remarks";
            this.remarks.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.remarks.Size = new System.Drawing.Size(437, 84);
            this.remarks.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 12;
            this.label4.Text = "移动路径";
            // 
            // movefiledir
            // 
            this.movefiledir.Location = new System.Drawing.Point(132, 76);
            this.movefiledir.Margin = new System.Windows.Forms.Padding(5);
            this.movefiledir.Name = "movefiledir";
            this.movefiledir.Size = new System.Drawing.Size(342, 29);
            this.movefiledir.TabIndex = 13;
            this.movefiledir.Text = "C:\\Users\\Administrator\\Desktop\\1\\1";
            // 
            // selectmovefiledir
            // 
            this.selectmovefiledir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.selectmovefiledir.Location = new System.Drawing.Point(487, 69);
            this.selectmovefiledir.Margin = new System.Windows.Forms.Padding(5);
            this.selectmovefiledir.Name = "selectmovefiledir";
            this.selectmovefiledir.Size = new System.Drawing.Size(125, 40);
            this.selectmovefiledir.TabIndex = 14;
            this.selectmovefiledir.Text = "选择目录";
            this.selectmovefiledir.UseVisualStyleBackColor = true;
            this.selectmovefiledir.Click += new System.EventHandler(this.selectmovefiledir_Click);
            // 
            // slectmoveexepath
            // 
            this.slectmoveexepath.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.slectmoveexepath.Location = new System.Drawing.Point(487, 171);
            this.slectmoveexepath.Margin = new System.Windows.Forms.Padding(5);
            this.slectmoveexepath.Name = "slectmoveexepath";
            this.slectmoveexepath.Size = new System.Drawing.Size(125, 40);
            this.slectmoveexepath.TabIndex = 17;
            this.slectmoveexepath.Text = "选择目录";
            this.slectmoveexepath.UseVisualStyleBackColor = true;
            this.slectmoveexepath.Click += new System.EventHandler(this.slectmoveexepath_Click);
            // 
            // moveexepath
            // 
            this.moveexepath.Location = new System.Drawing.Point(132, 174);
            this.moveexepath.Margin = new System.Windows.Forms.Padding(5);
            this.moveexepath.Name = "moveexepath";
            this.moveexepath.Size = new System.Drawing.Size(342, 29);
            this.moveexepath.TabIndex = 16;
            this.moveexepath.Text = "C:\\Users\\Administrator\\Desktop\\1\\2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 177);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "移动路径";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(113, 397);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(412, 397);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 29);
            this.dateTimePicker2.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 397);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 21);
            this.label6.TabIndex = 20;
            this.label6.Text = "压缩时间";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(332, 397);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 21);
            this.label7.TabIndex = 21;
            this.label7.Text = "移动时间";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 460);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.slectmoveexepath);
            this.Controls.Add(this.moveexepath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.selectmovefiledir);
            this.Controls.Add(this.movefiledir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.remarks);
            this.Controls.Add(this.selectsmarkPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.smarkPath);
            this.Controls.Add(this.selectexepath);
            this.Controls.Add(this.exepath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectdir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filedir);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "自解压生成";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox filedir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button selectdir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox exepath;
        private System.Windows.Forms.Button selectexepath;
        private System.Windows.Forms.TextBox smarkPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button selectsmarkPath;
        private System.Windows.Forms.TextBox remarks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox movefiledir;
        private System.Windows.Forms.Button selectmovefiledir;
        private System.Windows.Forms.Button slectmoveexepath;
        private System.Windows.Forms.TextBox moveexepath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

