using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hexa.NET.ImGuiNodeEditor
{ 
    public unsafe partial class ImGuiNodeEditor
    {
        public static void SetImGuiContext(ImGuiContextPtr ctx)
        {
            SetImGuiContextNative(ctx);
        }
    }
}
