using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures
{
    public interface IStyleFactory
    {
        Color BackgroundColor();
        Color ButtonColor();
        Color TextColor();
    }
}
