using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace AppliedProblem1
{
	public class FlashLight : Panel
	{
		public FlashLight( int nLocationX, int nLocationY, int nHeight, int nWidth )
		{
			this.BackColor = Color.Blue;
			this.BorderStyle = BorderStyle.Fixed3D;
			this.Location = new Point( nLocationX, nLocationY );
			this.Size = new Size( nWidth, nHeight );
		}

		public void TurnOnLight()
		{
			BackColor = Color.Red;
		}
		public void TurnOffLight()
		{
			BackColor = Color.Blue;
		}
	}
}
