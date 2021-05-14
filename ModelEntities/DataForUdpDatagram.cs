using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelEntities
{
    [Serializable]
    public class DataForUdpDatagram
    {
        public float current_deck_position_shipx { get; set; }
        public float current_deck_position_shipy { get; set; }
        public float current_deck_position_shipz { get; set; }
        public float current_positionx { get; set; }
        public float current_positiony { get; set; }
        public float current_positionz { get; set; }
        public float current_phi { get; set; }
        public float current_theta { get; set; }
        public float current_psi { get; set; }
        public float filter_Uact1l { get; set; }
        public float filter_Uact1r { get; set; }
        public float filter_Uact2l { get; set; }
        public float filter_Uact2r { get; set; }
        public float filter_Uact3l { get; set; }
        public float filter_Uact3r { get; set; }
        public float current_delta_tefl { get; set; }
        public float current_delta_tefr { get; set; }
        public float current_Tl { get; set; }
        public float current_Tr { get; set; }
        public bool landing_gear { get; set; }
        public bool tail_hook { get; set; }
        public bool wing_damage { get; set; }
        public bool land_flag { get; set; }

        public byte[] ToBytes()
        {
            byte[] temp = new byte[80];

            Buffer.BlockCopy(BitConverter.GetBytes(current_deck_position_shipx), 0, temp, 0, 4);
            Buffer.BlockCopy(BitConverter.GetBytes(current_deck_position_shipy), 0, temp, 4, 4);
            Buffer.BlockCopy(BitConverter.GetBytes(current_deck_position_shipz), 0, temp, 8, 4);
            Buffer.BlockCopy(BitConverter.GetBytes(current_positionx), 0, temp, 12, 4);
            Buffer.BlockCopy(BitConverter.GetBytes(current_positiony), 0, temp, 16, 4);
            Buffer.BlockCopy(BitConverter.GetBytes(current_positionz), 0, temp, 20, 4);
            Buffer.BlockCopy(BitConverter.GetBytes(current_phi), 0, temp, 24, 4);
            Buffer.BlockCopy(BitConverter.GetBytes(current_theta), 0, temp, 28, 4);
            Buffer.BlockCopy(BitConverter.GetBytes(current_psi), 0, temp, 32, 4);
            Buffer.BlockCopy(BitConverter.GetBytes(filter_Uact1l), 0, temp, 36, 4);
            Buffer.BlockCopy(BitConverter.GetBytes(filter_Uact1r), 0, temp, 40, 4);
            Buffer.BlockCopy(BitConverter.GetBytes(filter_Uact2l), 0, temp, 44, 4);
            Buffer.BlockCopy(BitConverter.GetBytes(filter_Uact2r), 0, temp, 48, 4);
            Buffer.BlockCopy(BitConverter.GetBytes(filter_Uact3l), 0, temp, 52, 4);
            Buffer.BlockCopy(BitConverter.GetBytes(filter_Uact3r), 0, temp, 56, 4);
            Buffer.BlockCopy(BitConverter.GetBytes(current_delta_tefl), 0, temp, 60, 4);
            Buffer.BlockCopy(BitConverter.GetBytes(current_delta_tefr), 0, temp, 64, 4);
            Buffer.BlockCopy(BitConverter.GetBytes(current_Tl), 0, temp, 68, 4);
            Buffer.BlockCopy(BitConverter.GetBytes(current_Tr), 0, temp, 72, 4);
            Buffer.BlockCopy(BitConverter.GetBytes(landing_gear), 0, temp, 76, 1);
            Buffer.BlockCopy(BitConverter.GetBytes(tail_hook), 0, temp, 77, 1);
            Buffer.BlockCopy(BitConverter.GetBytes(wing_damage), 0, temp, 78, 1);
            Buffer.BlockCopy(BitConverter.GetBytes(land_flag), 0, temp, 79, 1);
            return temp;
        }
    }
}
