namespace FlightArrivals_B
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
            this.lstArrivals = new System.Windows.Forms.ListBox();
            this.lblFlight = new System.Windows.Forms.Label();
            this.lblDeparture = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblArrivals = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstArrivals
            // 
            this.lstArrivals.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.lstArrivals.FormattingEnabled = true;
            this.lstArrivals.ItemHeight = 16;
            this.lstArrivals.Location = new System.Drawing.Point(40, 80);
            this.lstArrivals.Name = "lstArrivals";
            this.lstArrivals.Size = new System.Drawing.Size(300, 148);
            this.lstArrivals.TabIndex = 17;
            this.lstArrivals.SelectedIndexChanged += new System.EventHandler(this.lstArrivals_SelectedIndexChanged);
            // 
            // lblFlight
            // 
            this.lblFlight.AutoSize = true;
            this.lblFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlight.ForeColor = System.Drawing.Color.Coral;
            this.lblFlight.Location = new System.Drawing.Point(40, 60);
            this.lblFlight.Name = "lblFlight";
            this.lblFlight.Size = new System.Drawing.Size(46, 16);
            this.lblFlight.TabIndex = 19;
            this.lblFlight.Text = "Flight";
            // 
            // lblDeparture
            // 
            this.lblDeparture.AutoSize = true;
            this.lblDeparture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeparture.ForeColor = System.Drawing.Color.Coral;
            this.lblDeparture.Location = new System.Drawing.Point(160, 60);
            this.lblDeparture.Name = "lblDeparture";
            this.lblDeparture.Size = new System.Drawing.Size(77, 16);
            this.lblDeparture.TabIndex = 20;
            this.lblDeparture.Text = "Departure";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.Coral;
            this.lblTime.Location = new System.Drawing.Point(280, 60);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(43, 16);
            this.lblTime.TabIndex = 21;
            this.lblTime.Text = "Time";
            // 
            // lblArrivals
            // 
            this.lblArrivals.AutoSize = true;
            this.lblArrivals.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblArrivals.Location = new System.Drawing.Point(120, 10);
            this.lblArrivals.Name = "lblArrivals";
            this.lblArrivals.Size = new System.Drawing.Size(147, 25);
            this.lblArrivals.TabIndex = 22;
            this.lblArrivals.Text = "Arrivals Board";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.lblArrivals);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDeparture);
            this.Controls.Add(this.lblFlight);
            this.Controls.Add(this.lstArrivals);
            this.Name = "Form1";
            this.Text = "Flight Arrivals";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstArrivals;
        private System.Windows.Forms.Label lblFlight;
        private System.Windows.Forms.Label lblDeparture;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblArrivals;
    }
}

