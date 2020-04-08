namespace ocrRecognition
{
    partial class FormMain
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
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonSaveTrainDataset = new System.Windows.Forms.Button();
            this.buttonMakeTask1 = new System.Windows.Forms.Button();
            this.labelStatusPre = new System.Windows.Forms.Label();
            this.groupBoxTask1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxPreTrain = new System.Windows.Forms.PictureBox();
            this.labelTestCountElements = new System.Windows.Forms.Label();
            this.labelTrainCountElements = new System.Windows.Forms.Label();
            this.buttonDelTestDatasetElem = new System.Windows.Forms.Button();
            this.buttonDelTrainDatasetElem = new System.Windows.Forms.Button();
            this.labelTestCount = new System.Windows.Forms.Label();
            this.labelTrainCount = new System.Windows.Forms.Label();
            this.labelCaptionTestDataset = new System.Windows.Forms.Label();
            this.labelPathSaveTestDataset = new System.Windows.Forms.Label();
            this.labelCaptionTestCharater = new System.Windows.Forms.Label();
            this.labelCaptionTrainCharater = new System.Windows.Forms.Label();
            this.comboBoxTestCharater = new System.Windows.Forms.ComboBox();
            this.comboBoxTrainCharater = new System.Windows.Forms.ComboBox();
            this.buttonSaveTestDataset = new System.Windows.Forms.Button();
            this.listBoxTestDataset = new System.Windows.Forms.ListBox();
            this.listBoxTrainDataset = new System.Windows.Forms.ListBox();
            this.buttonAsTest = new System.Windows.Forms.Button();
            this.buttonAsTrain = new System.Windows.Forms.Button();
            this.pictureBoxPreTest = new System.Windows.Forms.PictureBox();
            this.listBoxImages = new System.Windows.Forms.ListBox();
            this.buttonDeleteImages = new System.Windows.Forms.Button();
            this.labelPathSaveTrainDataset = new System.Windows.Forms.Label();
            this.labelCaptionTrainDataset = new System.Windows.Forms.Label();
            this.groupBoxTask2 = new System.Windows.Forms.GroupBox();
            this.buttonTestImageElem = new System.Windows.Forms.Button();
            this.labelOpenDll = new System.Windows.Forms.Label();
            this.pictureBoxImageElem = new System.Windows.Forms.PictureBox();
            this.buttonOpenDll = new System.Windows.Forms.Button();
            this.labelOpenTestImage = new System.Windows.Forms.Label();
            this.buttonImageElemOpen = new System.Windows.Forms.Button();
            this.groupBoxTask1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreTrain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreTest)).BeginInit();
            this.groupBoxTask2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageElem)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(6, 24);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(79, 23);
            this.buttonOpen.TabIndex = 1;
            this.buttonOpen.Text = "Add images";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonSaveTrainDataset
            // 
            this.buttonSaveTrainDataset.Location = new System.Drawing.Point(9, 394);
            this.buttonSaveTrainDataset.Name = "buttonSaveTrainDataset";
            this.buttonSaveTrainDataset.Size = new System.Drawing.Size(190, 27);
            this.buttonSaveTrainDataset.TabIndex = 3;
            this.buttonSaveTrainDataset.Text = "Save train dataset file as";
            this.buttonSaveTrainDataset.UseVisualStyleBackColor = true;
            this.buttonSaveTrainDataset.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonMakeTask1
            // 
            this.buttonMakeTask1.Location = new System.Drawing.Point(9, 459);
            this.buttonMakeTask1.Name = "buttonMakeTask1";
            this.buttonMakeTask1.Size = new System.Drawing.Size(387, 38);
            this.buttonMakeTask1.TabIndex = 5;
            this.buttonMakeTask1.Text = "Make train and test datasets";
            this.buttonMakeTask1.UseVisualStyleBackColor = true;
            this.buttonMakeTask1.Click += new System.EventHandler(this.buttonMakeTask1_Click);
            // 
            // labelStatusPre
            // 
            this.labelStatusPre.AutoSize = true;
            this.labelStatusPre.Location = new System.Drawing.Point(6, 167);
            this.labelStatusPre.Name = "labelStatusPre";
            this.labelStatusPre.Size = new System.Drawing.Size(116, 13);
            this.labelStatusPre.TabIndex = 7;
            this.labelStatusPre.Text = "You have added 0 files";
            // 
            // groupBoxTask1
            // 
            this.groupBoxTask1.Controls.Add(this.pictureBoxPreTrain);
            this.groupBoxTask1.Controls.Add(this.labelTestCountElements);
            this.groupBoxTask1.Controls.Add(this.labelTrainCountElements);
            this.groupBoxTask1.Controls.Add(this.buttonDelTestDatasetElem);
            this.groupBoxTask1.Controls.Add(this.buttonDelTrainDatasetElem);
            this.groupBoxTask1.Controls.Add(this.labelTestCount);
            this.groupBoxTask1.Controls.Add(this.labelTrainCount);
            this.groupBoxTask1.Controls.Add(this.labelCaptionTestDataset);
            this.groupBoxTask1.Controls.Add(this.labelPathSaveTestDataset);
            this.groupBoxTask1.Controls.Add(this.labelCaptionTestCharater);
            this.groupBoxTask1.Controls.Add(this.labelCaptionTrainCharater);
            this.groupBoxTask1.Controls.Add(this.comboBoxTestCharater);
            this.groupBoxTask1.Controls.Add(this.comboBoxTrainCharater);
            this.groupBoxTask1.Controls.Add(this.buttonSaveTestDataset);
            this.groupBoxTask1.Controls.Add(this.listBoxTestDataset);
            this.groupBoxTask1.Controls.Add(this.listBoxTrainDataset);
            this.groupBoxTask1.Controls.Add(this.buttonAsTest);
            this.groupBoxTask1.Controls.Add(this.buttonAsTrain);
            this.groupBoxTask1.Controls.Add(this.pictureBoxPreTest);
            this.groupBoxTask1.Controls.Add(this.listBoxImages);
            this.groupBoxTask1.Controls.Add(this.buttonDeleteImages);
            this.groupBoxTask1.Controls.Add(this.labelPathSaveTrainDataset);
            this.groupBoxTask1.Controls.Add(this.labelCaptionTrainDataset);
            this.groupBoxTask1.Controls.Add(this.buttonOpen);
            this.groupBoxTask1.Controls.Add(this.buttonMakeTask1);
            this.groupBoxTask1.Controls.Add(this.labelStatusPre);
            this.groupBoxTask1.Controls.Add(this.buttonSaveTrainDataset);
            this.groupBoxTask1.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask1.Name = "groupBoxTask1";
            this.groupBoxTask1.Size = new System.Drawing.Size(403, 512);
            this.groupBoxTask1.TabIndex = 9;
            this.groupBoxTask1.TabStop = false;
            this.groupBoxTask1.Text = "Making OCR dataset";
            // 
            // pictureBoxPreTrain
            // 
            this.pictureBoxPreTrain.Location = new System.Drawing.Point(153, 311);
            this.pictureBoxPreTrain.Name = "pictureBoxPreTrain";
            this.pictureBoxPreTrain.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxPreTrain.TabIndex = 34;
            this.pictureBoxPreTrain.TabStop = false;
            // 
            // labelTestCountElements
            // 
            this.labelTestCountElements.AutoSize = true;
            this.labelTestCountElements.Location = new System.Drawing.Point(255, 193);
            this.labelTestCountElements.Name = "labelTestCountElements";
            this.labelTestCountElements.Size = new System.Drawing.Size(58, 13);
            this.labelTestCountElements.TabIndex = 33;
            this.labelTestCountElements.Text = "0 elements";
            // 
            // labelTrainCountElements
            // 
            this.labelTrainCountElements.AutoSize = true;
            this.labelTrainCountElements.Location = new System.Drawing.Point(61, 193);
            this.labelTrainCountElements.Name = "labelTrainCountElements";
            this.labelTrainCountElements.Size = new System.Drawing.Size(58, 13);
            this.labelTrainCountElements.TabIndex = 32;
            this.labelTrainCountElements.Text = "0 elements";
            // 
            // buttonDelTestDatasetElem
            // 
            this.buttonDelTestDatasetElem.Location = new System.Drawing.Point(334, 188);
            this.buttonDelTestDatasetElem.Name = "buttonDelTestDatasetElem";
            this.buttonDelTestDatasetElem.Size = new System.Drawing.Size(63, 23);
            this.buttonDelTestDatasetElem.TabIndex = 31;
            this.buttonDelTestDatasetElem.Text = "delete";
            this.buttonDelTestDatasetElem.UseVisualStyleBackColor = true;
            this.buttonDelTestDatasetElem.Click += new System.EventHandler(this.buttonDelTestDatasetElem_Click);
            // 
            // buttonDelTrainDatasetElem
            // 
            this.buttonDelTrainDatasetElem.Location = new System.Drawing.Point(138, 188);
            this.buttonDelTrainDatasetElem.Name = "buttonDelTrainDatasetElem";
            this.buttonDelTrainDatasetElem.Size = new System.Drawing.Size(61, 23);
            this.buttonDelTrainDatasetElem.TabIndex = 30;
            this.buttonDelTrainDatasetElem.Text = "delete";
            this.buttonDelTrainDatasetElem.UseVisualStyleBackColor = true;
            this.buttonDelTrainDatasetElem.Click += new System.EventHandler(this.buttonDelTrainDatasetElem_Click);
            // 
            // labelTestCount
            // 
            this.labelTestCount.AutoSize = true;
            this.labelTestCount.Location = new System.Drawing.Point(205, 343);
            this.labelTestCount.Name = "labelTestCount";
            this.labelTestCount.Size = new System.Drawing.Size(38, 13);
            this.labelTestCount.TabIndex = 29;
            this.labelTestCount.Text = "Count:";
            // 
            // labelTrainCount
            // 
            this.labelTrainCount.AutoSize = true;
            this.labelTrainCount.Location = new System.Drawing.Point(8, 343);
            this.labelTrainCount.Name = "labelTrainCount";
            this.labelTrainCount.Size = new System.Drawing.Size(38, 13);
            this.labelTrainCount.TabIndex = 28;
            this.labelTrainCount.Text = "Count:";
            // 
            // labelCaptionTestDataset
            // 
            this.labelCaptionTestDataset.AutoSize = true;
            this.labelCaptionTestDataset.Location = new System.Drawing.Point(204, 193);
            this.labelCaptionTestDataset.Name = "labelCaptionTestDataset";
            this.labelCaptionTestDataset.Size = new System.Drawing.Size(55, 13);
            this.labelCaptionTestDataset.TabIndex = 27;
            this.labelCaptionTestDataset.Text = "Test data:";
            // 
            // labelPathSaveTestDataset
            // 
            this.labelPathSaveTestDataset.AutoSize = true;
            this.labelPathSaveTestDataset.Location = new System.Drawing.Point(206, 424);
            this.labelPathSaveTestDataset.Name = "labelPathSaveTestDataset";
            this.labelPathSaveTestDataset.Size = new System.Drawing.Size(32, 13);
            this.labelPathSaveTestDataset.TabIndex = 26;
            this.labelPathSaveTestDataset.Text = "Path:";
            // 
            // labelCaptionTestCharater
            // 
            this.labelCaptionTestCharater.AutoSize = true;
            this.labelCaptionTestCharater.Location = new System.Drawing.Point(204, 318);
            this.labelCaptionTestCharater.Name = "labelCaptionTestCharater";
            this.labelCaptionTestCharater.Size = new System.Drawing.Size(47, 13);
            this.labelCaptionTestCharater.TabIndex = 25;
            this.labelCaptionTestCharater.Text = "Charater";
            // 
            // labelCaptionTrainCharater
            // 
            this.labelCaptionTrainCharater.AutoSize = true;
            this.labelCaptionTrainCharater.Location = new System.Drawing.Point(8, 318);
            this.labelCaptionTrainCharater.Name = "labelCaptionTrainCharater";
            this.labelCaptionTrainCharater.Size = new System.Drawing.Size(47, 13);
            this.labelCaptionTrainCharater.TabIndex = 24;
            this.labelCaptionTrainCharater.Text = "Charater";
            // 
            // comboBoxTestCharater
            // 
            this.comboBoxTestCharater.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTestCharater.FormattingEnabled = true;
            this.comboBoxTestCharater.Location = new System.Drawing.Point(258, 315);
            this.comboBoxTestCharater.Name = "comboBoxTestCharater";
            this.comboBoxTestCharater.Size = new System.Drawing.Size(79, 21);
            this.comboBoxTestCharater.TabIndex = 23;
            this.comboBoxTestCharater.TabStop = false;
            this.comboBoxTestCharater.SelectedIndexChanged += new System.EventHandler(this.comboBoxTestCharater_SelectedIndexChanged);
            this.comboBoxTestCharater.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxTestCharater_KeyDown);
            this.comboBoxTestCharater.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comboBoxTestCharater_KeyUp);
            // 
            // comboBoxTrainCharater
            // 
            this.comboBoxTrainCharater.CausesValidation = false;
            this.comboBoxTrainCharater.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTrainCharater.FormattingEnabled = true;
            this.comboBoxTrainCharater.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxTrainCharater.Location = new System.Drawing.Point(58, 315);
            this.comboBoxTrainCharater.Name = "comboBoxTrainCharater";
            this.comboBoxTrainCharater.Size = new System.Drawing.Size(79, 21);
            this.comboBoxTrainCharater.TabIndex = 22;
            this.comboBoxTrainCharater.TabStop = false;
            this.comboBoxTrainCharater.SelectedIndexChanged += new System.EventHandler(this.comboBoxTrainCharater_SelectedIndexChanged);
            this.comboBoxTrainCharater.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBoxTrainCharater_KeyDown);
            this.comboBoxTrainCharater.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comboBoxTrainCharater_KeyUp);
            // 
            // buttonSaveTestDataset
            // 
            this.buttonSaveTestDataset.Location = new System.Drawing.Point(205, 394);
            this.buttonSaveTestDataset.Name = "buttonSaveTestDataset";
            this.buttonSaveTestDataset.Size = new System.Drawing.Size(189, 27);
            this.buttonSaveTestDataset.TabIndex = 21;
            this.buttonSaveTestDataset.Text = "Save test dataset file as";
            this.buttonSaveTestDataset.UseVisualStyleBackColor = true;
            this.buttonSaveTestDataset.Click += new System.EventHandler(this.buttonSaveTestDataset_Click);
            // 
            // listBoxTestDataset
            // 
            this.listBoxTestDataset.FormattingEnabled = true;
            this.listBoxTestDataset.Location = new System.Drawing.Point(205, 214);
            this.listBoxTestDataset.Name = "listBoxTestDataset";
            this.listBoxTestDataset.Size = new System.Drawing.Size(191, 95);
            this.listBoxTestDataset.TabIndex = 20;
            this.listBoxTestDataset.SelectedIndexChanged += new System.EventHandler(this.listBoxTestDataset_SelectedIndexChanged);
            // 
            // listBoxTrainDataset
            // 
            this.listBoxTrainDataset.FormattingEnabled = true;
            this.listBoxTrainDataset.Location = new System.Drawing.Point(10, 214);
            this.listBoxTrainDataset.Name = "listBoxTrainDataset";
            this.listBoxTrainDataset.Size = new System.Drawing.Size(189, 95);
            this.listBoxTrainDataset.TabIndex = 19;
            this.listBoxTrainDataset.SelectedIndexChanged += new System.EventHandler(this.listBoxTrainDataset_SelectedIndexChanged);
            // 
            // buttonAsTest
            // 
            this.buttonAsTest.Location = new System.Drawing.Point(328, 24);
            this.buttonAsTest.Name = "buttonAsTest";
            this.buttonAsTest.Size = new System.Drawing.Size(67, 23);
            this.buttonAsTest.TabIndex = 18;
            this.buttonAsTest.Text = "As Test";
            this.buttonAsTest.UseVisualStyleBackColor = true;
            this.buttonAsTest.Click += new System.EventHandler(this.buttonAsTest_Click);
            // 
            // buttonAsTrain
            // 
            this.buttonAsTrain.Location = new System.Drawing.Point(256, 24);
            this.buttonAsTrain.Name = "buttonAsTrain";
            this.buttonAsTrain.Size = new System.Drawing.Size(69, 23);
            this.buttonAsTrain.TabIndex = 17;
            this.buttonAsTrain.Text = "As Train";
            this.buttonAsTrain.UseVisualStyleBackColor = true;
            this.buttonAsTrain.Click += new System.EventHandler(this.buttonAsTrain_Click);
            // 
            // pictureBoxPreTest
            // 
            this.pictureBoxPreTest.Location = new System.Drawing.Point(352, 311);
            this.pictureBoxPreTest.Name = "pictureBoxPreTest";
            this.pictureBoxPreTest.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxPreTest.TabIndex = 16;
            this.pictureBoxPreTest.TabStop = false;
            // 
            // listBoxImages
            // 
            this.listBoxImages.FormattingEnabled = true;
            this.listBoxImages.Location = new System.Drawing.Point(6, 53);
            this.listBoxImages.Name = "listBoxImages";
            this.listBoxImages.Size = new System.Drawing.Size(391, 108);
            this.listBoxImages.TabIndex = 15;
            // 
            // buttonDeleteImages
            // 
            this.buttonDeleteImages.Location = new System.Drawing.Point(86, 24);
            this.buttonDeleteImages.Name = "buttonDeleteImages";
            this.buttonDeleteImages.Size = new System.Drawing.Size(85, 23);
            this.buttonDeleteImages.TabIndex = 14;
            this.buttonDeleteImages.Text = "Delete image";
            this.buttonDeleteImages.UseVisualStyleBackColor = true;
            this.buttonDeleteImages.Click += new System.EventHandler(this.buttonDeleteImages_Click);
            // 
            // labelPathSaveTrainDataset
            // 
            this.labelPathSaveTrainDataset.AutoSize = true;
            this.labelPathSaveTrainDataset.Location = new System.Drawing.Point(8, 424);
            this.labelPathSaveTrainDataset.Name = "labelPathSaveTrainDataset";
            this.labelPathSaveTrainDataset.Size = new System.Drawing.Size(32, 13);
            this.labelPathSaveTrainDataset.TabIndex = 13;
            this.labelPathSaveTrainDataset.Text = "Path:";
            // 
            // labelCaptionTrainDataset
            // 
            this.labelCaptionTrainDataset.AutoSize = true;
            this.labelCaptionTrainDataset.Location = new System.Drawing.Point(8, 193);
            this.labelCaptionTrainDataset.Name = "labelCaptionTrainDataset";
            this.labelCaptionTrainDataset.Size = new System.Drawing.Size(58, 13);
            this.labelCaptionTrainDataset.TabIndex = 1;
            this.labelCaptionTrainDataset.Text = "Train data:";
            // 
            // groupBoxTask2
            // 
            this.groupBoxTask2.Controls.Add(this.buttonTestImageElem);
            this.groupBoxTask2.Controls.Add(this.labelOpenDll);
            this.groupBoxTask2.Controls.Add(this.pictureBoxImageElem);
            this.groupBoxTask2.Controls.Add(this.buttonOpenDll);
            this.groupBoxTask2.Controls.Add(this.labelOpenTestImage);
            this.groupBoxTask2.Controls.Add(this.buttonImageElemOpen);
            this.groupBoxTask2.Location = new System.Drawing.Point(442, 12);
            this.groupBoxTask2.Name = "groupBoxTask2";
            this.groupBoxTask2.Size = new System.Drawing.Size(253, 512);
            this.groupBoxTask2.TabIndex = 10;
            this.groupBoxTask2.TabStop = false;
            this.groupBoxTask2.Text = "Testing OCR element";
            // 
            // buttonTestImageElem
            // 
            this.buttonTestImageElem.Location = new System.Drawing.Point(12, 198);
            this.buttonTestImageElem.Name = "buttonTestImageElem";
            this.buttonTestImageElem.Size = new System.Drawing.Size(231, 42);
            this.buttonTestImageElem.TabIndex = 15;
            this.buttonTestImageElem.Text = "Test";
            this.buttonTestImageElem.UseVisualStyleBackColor = true;
            // 
            // labelOpenDll
            // 
            this.labelOpenDll.AutoSize = true;
            this.labelOpenDll.Location = new System.Drawing.Point(12, 172);
            this.labelOpenDll.Name = "labelOpenDll";
            this.labelOpenDll.Size = new System.Drawing.Size(32, 13);
            this.labelOpenDll.TabIndex = 14;
            this.labelOpenDll.Text = "Path:";
            // 
            // pictureBoxImageElem
            // 
            this.pictureBoxImageElem.Location = new System.Drawing.Point(109, 87);
            this.pictureBoxImageElem.Name = "pictureBoxImageElem";
            this.pictureBoxImageElem.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxImageElem.TabIndex = 11;
            this.pictureBoxImageElem.TabStop = false;
            // 
            // buttonOpenDll
            // 
            this.buttonOpenDll.Location = new System.Drawing.Point(12, 139);
            this.buttonOpenDll.Name = "buttonOpenDll";
            this.buttonOpenDll.Size = new System.Drawing.Size(231, 23);
            this.buttonOpenDll.TabIndex = 13;
            this.buttonOpenDll.Text = "Open Neurosolution dll library ";
            this.buttonOpenDll.UseVisualStyleBackColor = true;
            // 
            // labelOpenTestImage
            // 
            this.labelOpenTestImage.AutoSize = true;
            this.labelOpenTestImage.Location = new System.Drawing.Point(12, 57);
            this.labelOpenTestImage.Name = "labelOpenTestImage";
            this.labelOpenTestImage.Size = new System.Drawing.Size(32, 13);
            this.labelOpenTestImage.TabIndex = 12;
            this.labelOpenTestImage.Text = "Path:";
            // 
            // buttonImageElemOpen
            // 
            this.buttonImageElemOpen.Location = new System.Drawing.Point(12, 24);
            this.buttonImageElemOpen.Name = "buttonImageElemOpen";
            this.buttonImageElemOpen.Size = new System.Drawing.Size(231, 23);
            this.buttonImageElemOpen.TabIndex = 0;
            this.buttonImageElemOpen.Text = "Open image";
            this.buttonImageElemOpen.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 527);
            this.Controls.Add(this.groupBoxTask2);
            this.Controls.Add(this.groupBoxTask1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ocrRecognition";
            this.groupBoxTask1.ResumeLayout(false);
            this.groupBoxTask1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreTrain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreTest)).EndInit();
            this.groupBoxTask2.ResumeLayout(false);
            this.groupBoxTask2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageElem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button buttonSaveTrainDataset;
        private System.Windows.Forms.Button buttonMakeTask1;
        private System.Windows.Forms.Label labelStatusPre;
        private System.Windows.Forms.GroupBox groupBoxTask1;
        private System.Windows.Forms.Label labelCaptionTrainDataset;
        private System.Windows.Forms.GroupBox groupBoxTask2;
        private System.Windows.Forms.Button buttonImageElemOpen;
        private System.Windows.Forms.Label labelOpenDll;
        private System.Windows.Forms.Button buttonOpenDll;
        private System.Windows.Forms.Label labelOpenTestImage;
        private System.Windows.Forms.PictureBox pictureBoxImageElem;
        private System.Windows.Forms.Button buttonTestImageElem;
        private System.Windows.Forms.Label labelPathSaveTrainDataset;
        private System.Windows.Forms.PictureBox pictureBoxPreTest;
        private System.Windows.Forms.ListBox listBoxImages;
        private System.Windows.Forms.Button buttonDeleteImages;
        private System.Windows.Forms.Label labelTestCount;
        private System.Windows.Forms.Label labelTrainCount;
        private System.Windows.Forms.Label labelCaptionTestDataset;
        private System.Windows.Forms.Label labelPathSaveTestDataset;
        private System.Windows.Forms.Label labelCaptionTestCharater;
        private System.Windows.Forms.Label labelCaptionTrainCharater;
        private System.Windows.Forms.ComboBox comboBoxTestCharater;
        private System.Windows.Forms.Button buttonSaveTestDataset;
        private System.Windows.Forms.ListBox listBoxTestDataset;
        private System.Windows.Forms.ListBox listBoxTrainDataset;
        private System.Windows.Forms.Button buttonAsTest;
        private System.Windows.Forms.Button buttonAsTrain;
        private System.Windows.Forms.Button buttonDelTestDatasetElem;
        private System.Windows.Forms.Button buttonDelTrainDatasetElem;
        private System.Windows.Forms.ComboBox comboBoxTrainCharater;
        private System.Windows.Forms.Label labelTestCountElements;
        private System.Windows.Forms.Label labelTrainCountElements;
        private System.Windows.Forms.PictureBox pictureBoxPreTrain;
    }
}

