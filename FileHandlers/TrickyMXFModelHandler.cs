using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSX_Modder.Utilities;

namespace SSX_Xbox_Modder.FileHandlers
{
    internal class TrickyMXFModelHandler
    {
        public int U1;
        public int HeaderCount;
        public int HeaderSize;
        public int FileStart;
        public List<MPFModelHeader> ModelList = new List<MPFModelHeader>();
        public void load(string path)
        {
            using (Stream stream = File.Open(path, FileMode.Open))
            {
                U1 = StreamUtil.ReadInt32(stream);
                HeaderCount = StreamUtil.ReadInt16(stream);
                HeaderSize = StreamUtil.ReadInt16(stream);
                FileStart = StreamUtil.ReadInt32(stream);
                for (int i = 0; i < HeaderCount; i++)
                {
                    MPFModelHeader modelHeader = new MPFModelHeader();

                    modelHeader.FileName = StreamUtil.ReadString(stream, 16);
                    modelHeader.DataOffset = StreamUtil.ReadInt32(stream);
                    modelHeader.EntrySize = StreamUtil.ReadInt32(stream);
                    modelHeader.BoneDataOffset = StreamUtil.ReadInt32(stream);
                    modelHeader.Unknown = StreamUtil.ReadInt32(stream); //Leads To Bone
                    modelHeader.MaterialOffset = StreamUtil.ReadInt32(stream);
                    modelHeader.Unknown2 = StreamUtil.ReadInt32(stream); //Leads To Bone
                    modelHeader.IKPointOffset = StreamUtil.ReadInt32(stream);
                    modelHeader.ModelDataOffset = StreamUtil.ReadInt32(stream);
                    modelHeader.Unknown5 = StreamUtil.ReadInt32(stream); //Leads To Model Data Offset (Check Face3000 Brodi)
                    modelHeader.TriStripDataOffset = StreamUtil.ReadInt32(stream);
                    modelHeader.Unknown7 = StreamUtil.ReadInt32(stream); //Blank
                    modelHeader.VertexOffset = StreamUtil.ReadInt32(stream);
                    modelHeader.UnknownOffset = StreamUtil.ReadInt32(stream);
                    modelHeader.UnknownOffset2 = StreamUtil.ReadInt32(stream);
                    modelHeader.Unknown12 = StreamUtil.ReadInt32(stream); //Blank
                    modelHeader.Unknown13 = StreamUtil.ReadInt32(stream); //Blank
                    modelHeader.Unknown14 = StreamUtil.ReadInt32(stream); //Blank
                    modelHeader.Unknown15 = StreamUtil.ReadInt32(stream); //Blank
                    modelHeader.Unknown16 = StreamUtil.ReadInt32(stream); //Blank
                    modelHeader.Unknown17 = StreamUtil.ReadInt32(stream); //Blank
                    modelHeader.Unknown18 = StreamUtil.ReadInt32(stream); //Blank
                    modelHeader.Unknown19 = StreamUtil.ReadInt32(stream); //-1

                    stream.Position += 266;

                    modelHeader.UnknownCount1 = StreamUtil.ReadInt16(stream);
                    modelHeader.UnknownCount2 = StreamUtil.ReadInt16(stream);
                    modelHeader.UnknownCount3 = StreamUtil.ReadInt16(stream);
                    modelHeader.UnknownCount4 = StreamUtil.ReadInt16(stream);
                    modelHeader.UnknownCount5 = StreamUtil.ReadInt16(stream);
                    modelHeader.IKPointCount = StreamUtil.ReadInt16(stream);
                    modelHeader.UnknownCount7 = StreamUtil.ReadInt16(stream);
                    modelHeader.UnknownCount8 = StreamUtil.ReadInt16(stream);
                    modelHeader.UnknownCount9 = StreamUtil.ReadInt16(stream);
                    modelHeader.UnknownCount10 = StreamUtil.ReadInt16(stream);
                    modelHeader.UnknownCount11 = StreamUtil.ReadInt16(stream);
                    modelHeader.UnknownCount12 = StreamUtil.ReadInt16(stream);
                    modelHeader.UnknownCount13 = StreamUtil.ReadInt16(stream);

                }
            }
        }
    }

    public struct MPFModelHeader
    {
        //Main Header
        public string FileName;
        public int DataOffset;
        public int EntrySize;
        public int BoneDataOffset;
        public int Unknown;
        public int MaterialOffset;
        public int Unknown2;
        public int IKPointOffset;
        public int ModelDataOffset;
        public int Unknown5;
        public int TriStripDataOffset;
        public int Unknown7;
        public int VertexOffset;
        public int UnknownOffset;
        public int UnknownOffset2;
        public int Unknown11;
        public int Unknown12;
        public int Unknown13;
        public int Unknown14;
        public int Unknown15;
        public int Unknown16;
        public int Unknown17;
        public int Unknown18;    
        public int Unknown19;

        public int UnknownCount1;
        public int UnknownCount2;
        public int UnknownCount3;
        public int UnknownCount4;
        public int UnknownCount5;
        public int IKPointCount;
        public int UnknownCount7;
        public int UnknownCount8;
        public int UnknownCount9;
        public int UnknownCount10;
        public int UnknownCount11;
        public int UnknownCount12;
        public int UnknownCount13;

        public byte[] Matrix;
    }
}
