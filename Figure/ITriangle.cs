using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    public interface ITriangle: IFigure
    {
        double SideAB { get; set; }
        double SideBC { get; set; }
        double SideAC { get; set; }
        bool IsRightTriangle { get; }
    }
}
