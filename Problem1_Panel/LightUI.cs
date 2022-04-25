using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppliedProblem1
{
	//Public Methods and Members
	public partial class LightUI : Form
	{
		public LightUI()
		{
			InitializeComponent();
			this.KeyUp += LightUI_KeyUp;
			this.KeyDown += LightUI_KeyDown;
			this.ClientSize = new Size( FORMWIDTH, FORMHEIGHT );

			// Initialize variables
			int nSquareX = FORMWIDTH/4;
			int nSquareY = FORMWIDTH/4;
			int nSquareWidth = 100;
			int nSquareHeight = 100;

			// Initialize members
			m_Square = new Square( nSquareX, nSquareY, nSquareWidth, nSquareHeight );

			// Add control items to form
			this.Controls.Add( m_Square );
		}
	}

	//Private Methods and Members
	public partial class LightUI : Form
	{
		//Member Variable
		const int FORMWIDTH = 500;
		const int FORMHEIGHT = 500;

		Square m_Square;
		bool m_isLeft;
		bool m_isRight;
		bool m_isUp;
		bool m_isDown;
		int m_nDist = 10;

		void LightUI_KeyDown( object sender, KeyEventArgs e )
		{
			if( e.KeyCode == Keys.Left ) {
				m_isLeft = true;
			}
			else if( e.KeyCode == Keys.Right ) {
				m_isRight = true;
			}
			else if( e.KeyCode == Keys.Up ) {
				m_isUp = true;
			}
			else if( e.KeyCode == Keys.Down ) {
				m_isDown = true;
			}

			// enable the timer when key down
			bool isOnMoving = ( m_isDown == true || m_isLeft == true || m_isRight == true || m_isUp == true );
			if( isOnMoving ) {
				m_tmrMove.Enabled = true;
			}
		}

		void LightUI_KeyUp( object sender, KeyEventArgs e )
		{
			// Stop Move
			if( e.KeyCode == Keys.Left ) {
				m_isLeft = false;
			}
			else if( e.KeyCode == Keys.Right ) {
				m_isRight = false;
			}
			else if( e.KeyCode == Keys.Up ) {
				m_isUp = false;
			}
			else if( e.KeyCode == Keys.Down ) {
				m_isDown = false;
			}
		}

		void tmrMove_Trick( object sender, EventArgs e )
		{
			// Limitation
			bool bisOutOfBoundaryLeft = m_Square.Left - m_nDist < 0;
			bool bisOutOfBoundaryRight = m_Square.Right + m_nDist > ClientSize.Width;
			bool bisOutOfBoundaryTop = m_Square.Top - m_nDist < 0;
			bool bisOutOfBoundaryBottom = m_Square.Bottom + m_nDist > ClientSize.Height;

			if( bisOutOfBoundaryLeft ) {
				m_isLeft = false;
			}
			if( bisOutOfBoundaryRight ) {
				m_isRight = false;
			}
			if( bisOutOfBoundaryTop ) {
				m_isUp = false;
			}
			if( bisOutOfBoundaryBottom ) {
				m_isDown = false;
			}

			int nDistanceX = 0;
			int nDistanceY = 0;

			if( m_isLeft ) {
				nDistanceX -= m_nDist;
			}
			if( m_isRight ) {
				nDistanceX += m_nDist;
			}
			if( m_isUp ) {
				nDistanceY -= m_nDist;
			}
			if( m_isDown ) {
				nDistanceY += m_nDist;
			}

			// Move the Sqaure
			m_Square.MoveTo( nDistanceX, nDistanceY );

			// stop the timer when no need to move
			bool isStopMoving = ( m_isDown == false && m_isLeft == false && m_isRight == false && m_isUp == false );
			if( isStopMoving ) {
				m_tmrMove.Enabled = false;
			}
		}
	}
}