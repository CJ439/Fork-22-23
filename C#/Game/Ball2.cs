using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace Game
{
    internal class Ball2 : Sprite
    {
        int m_xdir = 2;
        int m_ydir = 2;
        public Ball2(PictureBox picture, int xdir, int ydir) : base(picture)
        {
            m_xdir = xdir;
            m_ydir = ydir;
        }
        public override bool collision(PictureBox other)
        {
            Debug.Print(m_picture.Name + " collided with " + other.Name);
            // We collided, so let's figure out which way we should "bounce"
            // Clear
            //if (!m_parent.isClear(m_picture,m_picture.Location.X + m_xdir, m_picture.Location.Y))
            m_xdir *= 1;
            //if (!m_parent.isClear(m_picture, m_picture.Location.X, m_picture.Location.Y + m_ydir))
            m_ydir *= 1;

            return false; // bounce
        }
        public override void tick()
        {
            move(m_ydir, m_xdir);
        }
    }
}

