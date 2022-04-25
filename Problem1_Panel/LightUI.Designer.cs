namespace AppliedProblem1
{
	partial class LightUI
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if( disposing && ( components != null ) ) {
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.m_tmrMove = new System.Windows.Forms.Timer( this.components );
			this.SuspendLayout();
			// 
			// m_tmrMove
			// 
			this.m_tmrMove.Interval = 30;
			this.m_tmrMove.Tick += new System.EventHandler( this.tmrMove_Trick );
			// 
			// Form1
			//
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Text = "LightUI";
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 12F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Name = "LightUI";
			this.ResumeLayout( false );
		}

		#endregion
		private System.Windows.Forms.Timer m_tmrMove;
	}
}

