
namespace chosesubject
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_studentid = new System.Windows.Forms.TextBox();
            this.label_studentid = new System.Windows.Forms.Label();
            this.button_SelectName = new System.Windows.Forms.Button();
            this.label_studentname_show = new System.Windows.Forms.Label();
            this.label_studentname = new System.Windows.Forms.Label();
            this.DataGridView_top = new System.Windows.Forms.DataGridView();
            this.DataGridView_down = new System.Windows.Forms.DataGridView();
            this.label_top = new System.Windows.Forms.Label();
            this.label_down = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_select = new System.Windows.Forms.Button();
            this.label_mid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_down)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_studentid
            // 
            this.textBox_studentid.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_studentid.Location = new System.Drawing.Point(129, 50);
            this.textBox_studentid.Name = "textBox_studentid";
            this.textBox_studentid.Size = new System.Drawing.Size(196, 29);
            this.textBox_studentid.TabIndex = 6;
            // 
            // label_studentid
            // 
            this.label_studentid.AutoSize = true;
            this.label_studentid.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_studentid.Location = new System.Drawing.Point(69, 53);
            this.label_studentid.Name = "label_studentid";
            this.label_studentid.Size = new System.Drawing.Size(69, 19);
            this.label_studentid.TabIndex = 5;
            this.label_studentid.Text = "学号：";
            // 
            // button_SelectName
            // 
            this.button_SelectName.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_SelectName.Location = new System.Drawing.Point(350, 47);
            this.button_SelectName.Name = "button_SelectName";
            this.button_SelectName.Size = new System.Drawing.Size(99, 40);
            this.button_SelectName.TabIndex = 4;
            this.button_SelectName.Text = "查询选课";
            this.button_SelectName.UseVisualStyleBackColor = true;
            this.button_SelectName.Click += new System.EventHandler(this.button_SelectName_Click);
            // 
            // label_studentname_show
            // 
            this.label_studentname_show.AutoSize = true;
            this.label_studentname_show.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_studentname_show.Location = new System.Drawing.Point(125, 115);
            this.label_studentname_show.Name = "label_studentname_show";
            this.label_studentname_show.Size = new System.Drawing.Size(229, 19);
            this.label_studentname_show.TabIndex = 8;
            this.label_studentname_show.Text = "输入学号并点击查询选课";
            // 
            // label_studentname
            // 
            this.label_studentname.AutoSize = true;
            this.label_studentname.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_studentname.Location = new System.Drawing.Point(69, 115);
            this.label_studentname.Name = "label_studentname";
            this.label_studentname.Size = new System.Drawing.Size(69, 19);
            this.label_studentname.TabIndex = 7;
            this.label_studentname.Text = "姓名：";
            // 
            // DataGridView_top
            // 
            this.DataGridView_top.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_top.Location = new System.Drawing.Point(47, 149);
            this.DataGridView_top.Name = "DataGridView_top";
            this.DataGridView_top.RowTemplate.Height = 23;
            this.DataGridView_top.Size = new System.Drawing.Size(656, 228);
            this.DataGridView_top.TabIndex = 9;
            // 
            // DataGridView_down
            // 
            this.DataGridView_down.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_down.Location = new System.Drawing.Point(47, 432);
            this.DataGridView_down.Name = "DataGridView_down";
            this.DataGridView_down.RowTemplate.Height = 23;
            this.DataGridView_down.Size = new System.Drawing.Size(656, 328);
            this.DataGridView_down.TabIndex = 10;
            // 
            // label_top
            // 
            this.label_top.AutoSize = true;
            this.label_top.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_top.Location = new System.Drawing.Point(12, 205);
            this.label_top.Name = "label_top";
            this.label_top.Size = new System.Drawing.Size(29, 76);
            this.label_top.TabIndex = 11;
            this.label_top.Text = "已\r\n选\r\n课\r\n程\r\n";
            // 
            // label_down
            // 
            this.label_down.AutoSize = true;
            this.label_down.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_down.Location = new System.Drawing.Point(12, 556);
            this.label_down.Name = "label_down";
            this.label_down.Size = new System.Drawing.Size(29, 76);
            this.label_down.TabIndex = 12;
            this.label_down.Text = "待\r\n选\r\n课\r\n程\r\n";
            // 
            // button_delete
            // 
            this.button_delete.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_delete.Location = new System.Drawing.Point(159, 790);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(99, 40);
            this.button_delete.TabIndex = 13;
            this.button_delete.Text = "退课";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_select
            // 
            this.button_select.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_select.Location = new System.Drawing.Point(424, 790);
            this.button_select.Name = "button_select";
            this.button_select.Size = new System.Drawing.Size(99, 40);
            this.button_select.TabIndex = 14;
            this.button_select.Text = "选课";
            this.button_select.UseVisualStyleBackColor = true;
            this.button_select.Click += new System.EventHandler(this.button_select_Click);
            // 
            // label_mid
            // 
            this.label_mid.AutoSize = true;
            this.label_mid.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_mid.Location = new System.Drawing.Point(204, 394);
            this.label_mid.Name = "label_mid";
            this.label_mid.Size = new System.Drawing.Size(299, 19);
            this.label_mid.TabIndex = 15;
            this.label_mid.Text = "已选课程数量：0 ，已选学分：0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 851);
            this.Controls.Add(this.label_mid);
            this.Controls.Add(this.button_select);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.label_down);
            this.Controls.Add(this.label_top);
            this.Controls.Add(this.DataGridView_down);
            this.Controls.Add(this.DataGridView_top);
            this.Controls.Add(this.label_studentname_show);
            this.Controls.Add(this.label_studentname);
            this.Controls.Add(this.textBox_studentid);
            this.Controls.Add(this.label_studentid);
            this.Controls.Add(this.button_SelectName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_down)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_studentid;
        private System.Windows.Forms.Label label_studentid;
        private System.Windows.Forms.Button button_SelectName;
        private System.Windows.Forms.Label label_studentname_show;
        private System.Windows.Forms.Label label_studentname;
        private System.Windows.Forms.DataGridView DataGridView_top;
        private System.Windows.Forms.DataGridView DataGridView_down;
        private System.Windows.Forms.Label label_top;
        private System.Windows.Forms.Label label_down;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_select;
        private System.Windows.Forms.Label label_mid;
    }
}

