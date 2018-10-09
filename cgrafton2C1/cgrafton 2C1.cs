using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cgrafton2C1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Minbutton_Click(object sender, EventArgs e)
        {
            byte byte1, byte2, byte3;
            sbyte sbyte1, sbyte2, sbyte3;
            short short1, short2, short3;
            ushort ushort1, ushort2, ushort3;
            int int1, int2, int3;
            uint uint1, uint2, uint3;
            long long1, long2, long3;
            ulong ulong1, ulong2, ulong3;
            float float1, float2, float3;
            double double1, double2, double3;
            decimal decimal1, decimal2, decimal3;

            byte1 = byte.MinValue;         byte1TextBox.Text = byte1.ToString();
            sbyte1 = sbyte.MinValue;       sbyte1TextBox.Text = sbyte1.ToString();
            short1 = Int16.MinValue;       short1TextBox.Text = short1.ToString();
            ushort1 = UInt16.MinValue;     ushort1TextBox.Text = ushort1.ToString();
            int1 = Int32.MinValue;         int1TextBox.Text = int1.ToString();
            uint1 = UInt32.MinValue;       uint1TextBox.Text = uint1.ToString();
            long1 = Int64.MinValue;        long1TextBox.Text = long1.ToString();
            ulong1 = UInt64.MinValue;      ulong1TextBox.Text = ulong1.ToString();
            float1 = Single.MinValue;      float1TextBox.Text = float1.ToString();
            double1 = double.MinValue;     double1TextBox.Text = double1.ToString();
            decimal1 = decimal.MinValue;   decimal1TextBox.Text = decimal1.ToString();
        }

        private void Maxbutton_Click(object sender, EventArgs e)
        {
            byte byte1, byte2, byte3;
            sbyte sbyte1, sbyte2, sbyte3;
            short short1, short2, short3;
            ushort ushort1, ushort2, ushort3;
            int int1, int2, int3;
            uint uint1, uint2, uint3;
            long long1, long2, long3;
            ulong ulong1, ulong2, ulong3;
            float float1, float2, float3;
            double double1, double2, double3;
            decimal decimal1, decimal2, decimal3;

            byte2 = byte.MaxValue; byte2TextBox.Text = byte2.ToString();
            sbyte2 = sbyte.MaxValue; sbyte2TextBox.Text = sbyte2.ToString();
            short2 = Int16.MaxValue; short2TextBox.Text = short2.ToString();
            ushort2 = UInt16.MaxValue; ushort2TextBox.Text = ushort2.ToString();
            int2 = Int32.MaxValue; int2TextBox.Text = int2.ToString();
            uint2 = UInt32.MaxValue; uint2TextBox.Text = uint2.ToString();
            long2 = Int64.MaxValue; long2TextBox.Text = long2.ToString();
            ulong2 = UInt64.MaxValue; ulong2TextBox.Text = ulong2.ToString();
            float2 = Single.MaxValue; float2TextBox.Text = float2.ToString();
            double2 = double.MaxValue; double2TextBox.Text = double2.ToString();
            decimal2 = decimal.MaxValue; decimal2TextBox.Text = decimal2.ToString();
        }
        
    }
}
