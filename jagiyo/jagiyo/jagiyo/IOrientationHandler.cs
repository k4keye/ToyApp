using System;
using System.Collections.Generic;
using System.Text;

namespace jagiyo
{
    public interface IOrientationHandler
    {
        void ForceLandscape();

        void ForcePortrait();
    }
}
