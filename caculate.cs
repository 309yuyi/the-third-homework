using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace current_caculator
{
    public class caculate
    {
        
        double U=0;
 
        double R1=0;
       
        double R2=0;
        
        double R3=0;
       
        double R4=0;
       
        public static double current1(double U, double R1, double R2, double R3, double R4)
        {
            double R = R2 * R4 / (R2 + R3 + R4) + 1 / (1 / (R1 + R2 * R3 / (R2 + R3 + R4)) + (R2 + R3 + R4) / (R3 * R4));
            double I = U / R;
            I=Math.Round(I,3);
            return I;
        }
        
        public static double power1(double U, double R1, double R2, double R3, double R4)
        {
            double R = R2 * R4 / (R2 + R3 + R4) + 1 / (1 / (R1 + R2 * R3 / (R2 + R3 + R4)) + (R2 + R3 + R4) / (R3 * R4));
            double I = U / R;
            double P = U * I;
            P=Math.Round(P,3);
            return P;
        }
       
        public static double current2(double U, double R1, double R2, double R3, double R4)
        {
            double R = R1 * R3 / (R1 + R2 + R3) + 1 / (1 / R4 + R1 * R2 / (R1 + R2 + R3) + (R1 + R2 + R3) / (R2 * R3));
            double I = U / R;
            I=Math.Round(I,3);
            return I;
        }
       
        public static double power2(double U, double R1, double R2, double R3, double R4)
        {
            double R = R1 * R3 / (R1 + R2 + R3) + 1 / (1 / R4 + R1 * R2 / (R1 + R2 + R3) + (R1 + R2 + R3) / (R2 * R3));
            double I = U / R;
            double P = U * I;
            P=Math.Round(P,3);
            return P;
        }
    }
}
