using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace AppliedProblem1
{
	//Public Methods and Members
	public partial class Square : Panel
	{
		//Make CombinedSquare
		public Square( int nLocationX, int nLocationY, int nHeight, int nWidth )
		{
			//Square Itself
			this.BackColor = Color.Blue;
			this.Location = new Point( nLocationX , nLocationY );
			this.Size = new Size( nWidth, nHeight );

			//Add Four FlashLights
			int nLightWidth = 30;
			int nLightHeight = 30;
			
			m_LeftFL = new FlashLight( 0, ( nHeight-nLightHeight ) / 2, nLightWidth, nLightHeight );
			m_RightFL = new FlashLight( (nHeight - nLightHeight), ( nHeight - nLightHeight ) / 2, nLightWidth, nLightHeight );
			m_TopFL = new FlashLight( ( nHeight - nLightHeight ) / 2, ( nHeight - nLightHeight ), nLightWidth, nLightHeight );
			m_BottomFL = new FlashLight( ( nHeight - nLightHeight ) / 2, 0, nLightWidth, nLightHeight );

			this.Controls.Add( m_LeftFL );
			this.Controls.Add( m_RightFL );
			this.Controls.Add( m_TopFL );
			this.Controls.Add( m_BottomFL );
		}

		public void MoveTo( int nX, int nY )
		{
			if( nX != 0 ) {
				MoveX( nX );
			}
			else {
				m_RightFL.TurnOffLight();
				m_LeftFL.TurnOffLight();
			}
			if( nY != 0 ) {
				MoveY( nY );
			}
			else {
				m_BottomFL.TurnOffLight();
				m_TopFL.TurnOffLight();
			}
		}
	}

	//Private Methods and Members
	public partial class Square : Panel
	{
		//Memeber Variable
		FlashLight m_LeftFL;
		FlashLight m_RightFL;
		FlashLight m_TopFL;
		FlashLight m_BottomFL;

		private void MoveX( int nDist )
		{
			Left += nDist;
			if( nDist > 0 ) {
				m_RightFL.TurnOnLight();
			}
			else if( nDist < 0 ) {
				m_LeftFL.TurnOnLight();
			}
		}

		private void MoveY( int nDist )
		{
			Top += nDist;
			if( nDist > 0 ) {
				m_TopFL.TurnOnLight();
			}
			else if( nDist < 0 ) {
				m_BottomFL.TurnOnLight();
			}
		}
	}
}
