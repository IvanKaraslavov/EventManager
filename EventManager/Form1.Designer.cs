namespace EventManager
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label locationLabel;
            System.Windows.Forms.Label startLabel;
            System.Windows.Forms.Label endLabel;
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventManagerDataSet = new EventManager.EventManagerDataSet();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.eventBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.eventManagerDataSet1 = new EventManager.EventManagerDataSet1();
            this.eventTableAdapter = new EventManager.EventManagerDataSetTableAdapters.EventTableAdapter();
            this.tableAdapterManager = new EventManager.EventManagerDataSetTableAdapters.TableAdapterManager();
            this.eventTableAdapter1 = new EventManager.EventManagerDataSet1TableAdapters.EventTableAdapter();
            this.tableAdapterManager1 = new EventManager.EventManagerDataSet1TableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            locationLabel = new System.Windows.Forms.Label();
            startLabel = new System.Windows.Forms.Label();
            endLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventManagerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventManagerDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // locationLabel
            // 
            locationLabel.AutoSize = true;
            locationLabel.Location = new System.Drawing.Point(14, 53);
            locationLabel.Name = "locationLabel";
            locationLabel.Size = new System.Drawing.Size(66, 17);
            locationLabel.TabIndex = 5;
            locationLabel.Text = "Location:";
            // 
            // startLabel
            // 
            startLabel.AutoSize = true;
            startLabel.Location = new System.Drawing.Point(319, 26);
            startLabel.Name = "startLabel";
            startLabel.Size = new System.Drawing.Size(42, 17);
            startLabel.TabIndex = 7;
            startLabel.Text = "Start:";
            // 
            // endLabel
            // 
            endLabel.AutoSize = true;
            endLabel.Location = new System.Drawing.Point(319, 54);
            endLabel.Name = "endLabel";
            endLabel.Size = new System.Drawing.Size(37, 17);
            endLabel.TabIndex = 9;
            endLabel.Text = "End:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "name", true));
            this.nameTextBox.Location = new System.Drawing.Point(81, 22);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 22);
            this.nameTextBox.TabIndex = 4;
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataMember = "Event";
            this.eventBindingSource.DataSource = this.eventManagerDataSet;
            // 
            // eventManagerDataSet
            // 
            this.eventManagerDataSet.DataSetName = "EventManagerDataSet";
            this.eventManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // locationTextBox
            // 
            this.locationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.eventBindingSource, "location", true));
            this.locationTextBox.Location = new System.Drawing.Point(81, 50);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(200, 22);
            this.locationTextBox.TabIndex = 6;
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventBindingSource, "start", true));
            this.startDateTimePicker.Location = new System.Drawing.Point(386, 22);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(209, 22);
            this.startDateTimePicker.TabIndex = 8;
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.eventBindingSource, "end", true));
            this.endDateTimePicker.Location = new System.Drawing.Point(386, 50);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(209, 22);
            this.endDateTimePicker.TabIndex = 10;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.GhostWhite;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNext.Location = new System.Drawing.Point(100, 101);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(139, 41);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = "NEXT";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.GhostWhite;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPrev.Location = new System.Drawing.Point(445, 101);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(139, 41);
            this.btnPrev.TabIndex = 12;
            this.btnPrev.Text = "PREVIOUS";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.GhostWhite;
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLast.Location = new System.Drawing.Point(445, 158);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(139, 41);
            this.btnLast.TabIndex = 13;
            this.btnLast.Text = "LAST RECORD";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.GhostWhite;
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFirst.Location = new System.Drawing.Point(100, 158);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(139, 41);
            this.btnFirst.TabIndex = 14;
            this.btnFirst.Text = "FIRST RECORD";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.GhostWhite;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddNew.Location = new System.Drawing.Point(17, 280);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(139, 41);
            this.btnAddNew.TabIndex = 15;
            this.btnAddNew.Text = "ADD NEW";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.GhostWhite;
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave.Location = new System.Drawing.Point(217, 280);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(139, 41);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.GhostWhite;
            this.btnCancel.Enabled = false;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.Location = new System.Drawing.Point(413, 280);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(139, 41);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.GhostWhite;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUpdate.Location = new System.Drawing.Point(17, 384);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(139, 41);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.GhostWhite;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDelete.Location = new System.Drawing.Point(217, 384);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(139, 41);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // eventBindingSource1
            // 
            this.eventBindingSource1.DataMember = "Event";
            this.eventBindingSource1.DataSource = this.eventManagerDataSet1;
            // 
            // eventManagerDataSet1
            // 
            this.eventManagerDataSet1.DataSetName = "EventManagerDataSet1";
            this.eventManagerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventTableAdapter
            // 
            this.eventTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EventTableAdapter = this.eventTableAdapter;
            this.tableAdapterManager.UpdateOrder = EventManager.EventManagerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // eventTableAdapter1
            // 
            this.eventTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.EventTableAdapter = this.eventTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = EventManager.EventManagerDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Add New Record";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Edit Record";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(781, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "label4";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(642, 72);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(234, 24);
            this.comboBox1.TabIndex = 28;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(639, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "VIEW ALL EVENTS AND SELECT:";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::EventManager.Properties.Resources.glasses;
            this.pictureBox5.Location = new System.Drawing.Point(681, 131);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(290, 233);
            this.pictureBox5.TabIndex = 30;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EventManager.Properties.Resources.hat3;
            this.pictureBox1.Location = new System.Drawing.Point(478, 267);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 158);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::EventManager.Properties.Resources.balloons;
            this.pictureBox2.Location = new System.Drawing.Point(276, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(241, 286);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::EventManager.Properties.Resources.presents;
            this.pictureBox3.Location = new System.Drawing.Point(33, 271);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(323, 182);
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::EventManager.Properties.Resources.champagne;
            this.pictureBox4.Location = new System.Drawing.Point(-33, 63);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(189, 198);
            this.pictureBox4.TabIndex = 26;
            this.pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(968, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(locationLabel);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(startLabel);
            this.Controls.Add(this.startDateTimePicker);
            this.Controls.Add(endLabel);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox5);
            this.Name = "Form1";
            this.Text = "Event Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventManagerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventManagerDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private EventManagerDataSet eventManagerDataSet;
        private System.Windows.Forms.BindingSource eventBindingSource;
        private EventManagerDataSetTableAdapters.EventTableAdapter eventTableAdapter;
        private EventManagerDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private EventManagerDataSet1 eventManagerDataSet1;
        private System.Windows.Forms.BindingSource eventBindingSource1;
        private EventManagerDataSet1TableAdapters.EventTableAdapter eventTableAdapter1;
        private EventManagerDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

