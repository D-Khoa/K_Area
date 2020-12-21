using BaseLibrary.Elements;
using System.Linq;

namespace DrMarioProject.Assets
{
    public class Board20x20 : BaseBackground
    {
        public Board20x20(int width, int height) : base(width, height, 20, 10, 1)
        {

        }

        public void CheckRow()
        {
            for (int i = 0; i < Cells.Count; i++)
            {
                if (Cells.ElementAt(i).Value.All(x => x != null))
                {
                    Cells.Remove(Cells.ElementAt(i).Key);
                }
            }
            var r = Rows - 1;
            while (r > 0)
            {
                if (!Cells.ContainsKey(r))
                {
                    if (Cells.ContainsKey(r - 1))
                    {
                        for (int c = 0; c < Cells[r - 1].Length; c++)
                        {
                            if (Cells[r - 1][c] != null)
                            {
                                Cells[r - 1][c].ChangeLocation(c, r);
                            }
                        }
                        Cells.Add(r, Cells[r - 1]);
                        Cells.Remove(r - 1);
                        r = Rows;
                    }
                }
                r--;
            }
        }
    }
}
