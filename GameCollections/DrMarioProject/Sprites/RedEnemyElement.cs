using DrMarioProject.Modules;
using System.Drawing;

namespace DrMarioProject.Sprites
{
    public class RedEnemyElement : BaseElement
    {
        public RedEnemyElement(Size size, Point location) 
            : base(Color.Red, size, location, 1) { }
    }
}
