namespace task_seven
{
    partial class Bul_Function
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.func = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.answ = new System.Windows.Forms.Label();
            this.zero = new System.Windows.Forms.Button();
            this.one = new System.Windows.Forms.Button();
            this.star = new System.Windows.Forms.Button();
            this.calculate = new System.Windows.Forms.Button();
            this.answer = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(63, 41);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(202, 36);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // func
            // 
            this.func.AutoSize = true;
            this.func.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.func.Location = new System.Drawing.Point(15, 46);
            this.func.Name = "func";
            this.func.Size = new System.Drawing.Size(46, 25);
            this.func.TabIndex = 1;
            this.func.Text = "F = ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(321, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(366, 365);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // answ
            // 
            this.answ.AutoSize = true;
            this.answ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answ.Location = new System.Drawing.Point(15, 238);
            this.answ.Name = "answ";
            this.answ.Size = new System.Drawing.Size(78, 25);
            this.answ.TabIndex = 3;
            this.answ.Text = "Ответ:";
            // 
            // zero
            // 
            this.zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.zero.Location = new System.Drawing.Point(63, 99);
            this.zero.Name = "zero";
            this.zero.Size = new System.Drawing.Size(45, 43);
            this.zero.TabIndex = 4;
            this.zero.Text = "0";
            this.zero.UseVisualStyleBackColor = true;
            this.zero.Click += new System.EventHandler(this.zero_Click);
            // 
            // one
            // 
            this.one.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.one.Location = new System.Drawing.Point(114, 99);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(45, 43);
            this.one.TabIndex = 5;
            this.one.Text = "1";
            this.one.UseVisualStyleBackColor = true;
            this.one.Click += new System.EventHandler(this.one_Click);
            // 
            // star
            // 
            this.star.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.star.Location = new System.Drawing.Point(169, 99);
            this.star.Name = "star";
            this.star.Size = new System.Drawing.Size(45, 43);
            this.star.TabIndex = 6;
            this.star.Text = "*";
            this.star.UseVisualStyleBackColor = true;
            this.star.Click += new System.EventHandler(this.star_Click);
            // 
            // calculate
            // 
            this.calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculate.Location = new System.Drawing.Point(65, 153);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(200, 47);
            this.calculate.TabIndex = 7;
            this.calculate.Text = "Вычислить";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // answer
            // 
            this.answer.AutoSize = true;
            this.answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.answer.Location = new System.Drawing.Point(99, 238);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(0, 25);
            this.answer.TabIndex = 8;
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete.Location = new System.Drawing.Point(220, 99);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(45, 43);
            this.delete.TabIndex = 9;
            this.delete.Text = "Del";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bul_Function
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 446);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.star);
            this.Controls.Add(this.one);
            this.Controls.Add(this.zero);
            this.Controls.Add(this.answ);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.func);
            this.Controls.Add(this.textBox1);
            this.Name = "Bul_Function";
            this.Text = "Определитель монотонности";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label func;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label answ;
        private System.Windows.Forms.Button zero;
        private System.Windows.Forms.Button one;
        private System.Windows.Forms.Button star;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.Label answer;
        private System.Windows.Forms.Button delete;
    }
}

