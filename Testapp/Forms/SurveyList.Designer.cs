namespace gregg.Forms
{
    partial class SurveyList
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
            this.surveyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.surveyItemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.surveyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.surveyItemBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // surveyBindingSource
            // 
            this.surveyBindingSource.DataSource = typeof(Testapp.Models.Survey);
            // 
            // surveyItemBindingSource
            // 
            this.surveyItemBindingSource.DataSource = typeof(Testapp.Models.SurveyItem);
            // 
            // SurveyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 595);
            this.Name = "SurveyList";
            this.Text = "Survey";
            this.Load += new System.EventHandler(this.SurveyList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.surveyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.surveyItemBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource surveyBindingSource;
        private System.Windows.Forms.BindingSource surveyItemBindingSource;
    }
}