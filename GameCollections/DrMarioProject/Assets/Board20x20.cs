using BaseLibrary.Elements;
using System.Linq;

namespace DrMarioProject.Assets
{
    public class Board20x20 : BaseBackground
    {
        public Board20x20(int width, int height) : base(width, height, 20, 10)
        {

        }

        public void CheckRow(int rowIndex)
        {
            if (MidCells.ContainsKey(rowIndex)
                && MidCells[rowIndex].Where(x => x != null).Count() == Columns)
            {
                MidCells.Remove(rowIndex);
                for (int i = rowIndex; i >= 0; i--)
                {
                    if (MidCells.ContainsKey(i))
                    {
                        for (int j = 0; j < MidCells[i].Length; j++)
                        {
                            if (MidCells[i][j] != null)
                            {
                                MidCells[i][j].ChangeLocation(j, i + 1);
                            }
                        }
                        MidCells.Add(i + 1, MidCells[i]);
                        MidCells.Remove(i);
                    }
                }
            }
        }
    }
}
