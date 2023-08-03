namespace Inspimo_AdonetMovie
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
            this.dtgCategory = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCategoryID = new System.Windows.Forms.TextBox();
            this.btnCategoryList = new System.Windows.Forms.Button();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCategorySave = new System.Windows.Forms.Button();
            this.btnCategoryDelete = new System.Windows.Forms.Button();
            this.btnCategoryUpdate = new System.Windows.Forms.Button();
            this.btnMovieUpdate = new System.Windows.Forms.Button();
            this.btnMovieDelete = new System.Windows.Forms.Button();
            this.btnMovieSave = new System.Windows.Forms.Button();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMovieList = new System.Windows.Forms.Button();
            this.txtMovieID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtgMovie = new System.Windows.Forms.DataGridView();
            this.txtMovieImdb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMovieDuration = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCategoryCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnMovieProcedure = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMovie)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgCategory
            // 
            this.dtgCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCategory.Location = new System.Drawing.Point(0, 0);
            this.dtgCategory.Name = "dtgCategory";
            this.dtgCategory.RowHeadersWidth = 62;
            this.dtgCategory.RowTemplate.Height = 28;
            this.dtgCategory.Size = new System.Drawing.Size(490, 259);
            this.dtgCategory.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kategori ID:";
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.Location = new System.Drawing.Point(111, 292);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.Size = new System.Drawing.Size(217, 26);
            this.txtCategoryID.TabIndex = 2;
            // 
            // btnCategoryList
            // 
            this.btnCategoryList.Location = new System.Drawing.Point(111, 357);
            this.btnCategoryList.Name = "btnCategoryList";
            this.btnCategoryList.Size = new System.Drawing.Size(104, 32);
            this.btnCategoryList.TabIndex = 3;
            this.btnCategoryList.Text = "Listele";
            this.btnCategoryList.UseVisualStyleBackColor = true;
            this.btnCategoryList.Click += new System.EventHandler(this.btnCategoryList_Click);
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(111, 325);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(217, 26);
            this.txtCategoryName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kategori Adı:";
            // 
            // btnCategorySave
            // 
            this.btnCategorySave.Location = new System.Drawing.Point(221, 357);
            this.btnCategorySave.Name = "btnCategorySave";
            this.btnCategorySave.Size = new System.Drawing.Size(107, 32);
            this.btnCategorySave.TabIndex = 6;
            this.btnCategorySave.Text = "Ekle";
            this.btnCategorySave.UseVisualStyleBackColor = true;
            this.btnCategorySave.Click += new System.EventHandler(this.btnCategorySave_Click);
            // 
            // btnCategoryDelete
            // 
            this.btnCategoryDelete.Location = new System.Drawing.Point(111, 395);
            this.btnCategoryDelete.Name = "btnCategoryDelete";
            this.btnCategoryDelete.Size = new System.Drawing.Size(104, 35);
            this.btnCategoryDelete.TabIndex = 7;
            this.btnCategoryDelete.Text = "Sil";
            this.btnCategoryDelete.UseVisualStyleBackColor = true;
            this.btnCategoryDelete.Click += new System.EventHandler(this.btnCategoryDelete_Click);
            // 
            // btnCategoryUpdate
            // 
            this.btnCategoryUpdate.Location = new System.Drawing.Point(221, 396);
            this.btnCategoryUpdate.Name = "btnCategoryUpdate";
            this.btnCategoryUpdate.Size = new System.Drawing.Size(107, 34);
            this.btnCategoryUpdate.TabIndex = 8;
            this.btnCategoryUpdate.Text = "Güncelle";
            this.btnCategoryUpdate.UseVisualStyleBackColor = true;
            this.btnCategoryUpdate.Click += new System.EventHandler(this.btnCategoryUpdate_Click);
            // 
            // btnMovieUpdate
            // 
            this.btnMovieUpdate.Location = new System.Drawing.Point(751, 510);
            this.btnMovieUpdate.Name = "btnMovieUpdate";
            this.btnMovieUpdate.Size = new System.Drawing.Size(107, 34);
            this.btnMovieUpdate.TabIndex = 17;
            this.btnMovieUpdate.Text = "Güncelle";
            this.btnMovieUpdate.UseVisualStyleBackColor = true;
            this.btnMovieUpdate.Click += new System.EventHandler(this.btnMovieUpdate_Click);
            // 
            // btnMovieDelete
            // 
            this.btnMovieDelete.Location = new System.Drawing.Point(641, 509);
            this.btnMovieDelete.Name = "btnMovieDelete";
            this.btnMovieDelete.Size = new System.Drawing.Size(104, 35);
            this.btnMovieDelete.TabIndex = 16;
            this.btnMovieDelete.Text = "Sil";
            this.btnMovieDelete.UseVisualStyleBackColor = true;
            this.btnMovieDelete.Click += new System.EventHandler(this.btnMovieDelete_Click);
            // 
            // btnMovieSave
            // 
            this.btnMovieSave.Location = new System.Drawing.Point(751, 471);
            this.btnMovieSave.Name = "btnMovieSave";
            this.btnMovieSave.Size = new System.Drawing.Size(107, 32);
            this.btnMovieSave.TabIndex = 15;
            this.btnMovieSave.Text = "Ekle";
            this.btnMovieSave.UseVisualStyleBackColor = true;
            this.btnMovieSave.Click += new System.EventHandler(this.btnMovieSave_Click);
            // 
            // txtMovieName
            // 
            this.txtMovieName.Location = new System.Drawing.Point(641, 325);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(217, 26);
            this.txtMovieName.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(542, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Film Adı:";
            // 
            // btnMovieList
            // 
            this.btnMovieList.Location = new System.Drawing.Point(641, 471);
            this.btnMovieList.Name = "btnMovieList";
            this.btnMovieList.Size = new System.Drawing.Size(104, 32);
            this.btnMovieList.TabIndex = 12;
            this.btnMovieList.Text = "Listele";
            this.btnMovieList.UseVisualStyleBackColor = true;
            this.btnMovieList.Click += new System.EventHandler(this.btnMovieList_Click);
            // 
            // txtMovieID
            // 
            this.txtMovieID.Location = new System.Drawing.Point(641, 292);
            this.txtMovieID.Name = "txtMovieID";
            this.txtMovieID.Size = new System.Drawing.Size(217, 26);
            this.txtMovieID.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(542, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Film ID:";
            // 
            // dtgMovie
            // 
            this.dtgMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMovie.Location = new System.Drawing.Point(530, 0);
            this.dtgMovie.Name = "dtgMovie";
            this.dtgMovie.RowHeadersWidth = 62;
            this.dtgMovie.RowTemplate.Height = 28;
            this.dtgMovie.Size = new System.Drawing.Size(490, 259);
            this.dtgMovie.TabIndex = 9;
            // 
            // txtMovieImdb
            // 
            this.txtMovieImdb.Location = new System.Drawing.Point(641, 393);
            this.txtMovieImdb.Name = "txtMovieImdb";
            this.txtMovieImdb.Size = new System.Drawing.Size(217, 26);
            this.txtMovieImdb.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(542, 396);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Süre:";
            // 
            // txtMovieDuration
            // 
            this.txtMovieDuration.Location = new System.Drawing.Point(641, 360);
            this.txtMovieDuration.Name = "txtMovieDuration";
            this.txtMovieDuration.Size = new System.Drawing.Size(217, 26);
            this.txtMovieDuration.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(542, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Puan:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(542, 428);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "Kategori:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCategoryCount);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(1026, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 134);
            this.panel1.TabIndex = 24;
            // 
            // lblCategoryCount
            // 
            this.lblCategoryCount.AutoSize = true;
            this.lblCategoryCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCategoryCount.Location = new System.Drawing.Point(92, 64);
            this.lblCategoryCount.Name = "lblCategoryCount";
            this.lblCategoryCount.Size = new System.Drawing.Size(30, 32);
            this.lblCategoryCount.TabIndex = 27;
            this.lblCategoryCount.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(46, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 20);
            this.label8.TabIndex = 26;
            this.label8.Text = "Kategori Sayısı";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(1026, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 134);
            this.panel2.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(92, 77);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 20);
            this.label10.TabIndex = 29;
            this.label10.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(46, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 20);
            this.label11.TabIndex = 28;
            this.label11.Text = "Kategori Sayısı";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Location = new System.Drawing.Point(1026, 314);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(226, 134);
            this.panel3.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(92, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 20);
            this.label12.TabIndex = 31;
            this.label12.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(46, 43);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 20);
            this.label13.TabIndex = 30;
            this.label13.Text = "Kategori Sayısı";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Location = new System.Drawing.Point(1026, 469);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(226, 134);
            this.panel4.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(92, 71);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 20);
            this.label14.TabIndex = 33;
            this.label14.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(46, 41);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(113, 20);
            this.label15.TabIndex = 32;
            this.label15.Text = "Kategori Sayısı";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(641, 428);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(217, 33);
            this.cmbCategory.TabIndex = 34;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // btnMovieProcedure
            // 
            this.btnMovieProcedure.Location = new System.Drawing.Point(641, 550);
            this.btnMovieProcedure.Name = "btnMovieProcedure";
            this.btnMovieProcedure.Size = new System.Drawing.Size(104, 35);
            this.btnMovieProcedure.TabIndex = 35;
            this.btnMovieProcedure.Text = "Prosedür";
            this.btnMovieProcedure.UseVisualStyleBackColor = true;
            this.btnMovieProcedure.Click += new System.EventHandler(this.btnMovieProcedure_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 654);
            this.Controls.Add(this.btnMovieProcedure);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMovieImdb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMovieDuration);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnMovieUpdate);
            this.Controls.Add(this.btnMovieDelete);
            this.Controls.Add(this.btnMovieSave);
            this.Controls.Add(this.txtMovieName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMovieList);
            this.Controls.Add(this.txtMovieID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtgMovie);
            this.Controls.Add(this.btnCategoryUpdate);
            this.Controls.Add(this.btnCategoryDelete);
            this.Controls.Add(this.btnCategorySave);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCategoryList);
            this.Controls.Add(this.txtCategoryID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgCategory);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMovie)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.Button btnCategoryList;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCategorySave;
        private System.Windows.Forms.Button btnCategoryDelete;
        private System.Windows.Forms.Button btnCategoryUpdate;
        private System.Windows.Forms.Button btnMovieUpdate;
        private System.Windows.Forms.Button btnMovieDelete;
        private System.Windows.Forms.Button btnMovieSave;
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMovieList;
        private System.Windows.Forms.TextBox txtMovieID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgMovie;
        private System.Windows.Forms.TextBox txtMovieImdb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMovieDuration;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblCategoryCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Button btnMovieProcedure;
    }
}

