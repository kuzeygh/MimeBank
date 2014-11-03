﻿using System.Collections.Generic;
using System.Linq;

namespace MimeBank
{
    public static class HeaderData
    {
        private static int maxBufferSize = 0;

        public static int MaxBufferSize
        {
            get
            {
                if (maxBufferSize == 0)
                {
                    maxBufferSize = Items.Max(h => h.HeaderLength);
                }
                return maxBufferSize;
            }
        }

        public static List<FileHeader> Items = new List<FileHeader>()
        {
            new FileHeader(FileType.Audio, "ra", "2E 72 61 FD 00"),
            new FileHeader(FileType.Audio, "ra", "2E 52 4D 46 00 00 00 12 00"),
            new FileHeader(FileType.Audio, "ogg", "4F 67 67 53 00 02 00 00 00 00 00 00 00 00"),
            new FileHeader(FileType.Audio, "mp3", "49 44 33"),
            new FileHeader(FileType.Audio, "wav", "52 49 46 46 ?? ?? ?? ?? 57 41 56 45 66 6D 74 20"),

            new FileHeader(FileType.Image, "gif", "47 49 46 38"),
            new FileHeader(FileType.Image, "jpg", "FF D8 FF"),
            new FileHeader(FileType.Image, "jpg", "00 00 00 0C 6A 50 20 20 0D 0A"),
            new FileHeader(FileType.Image, "bmp", "42 4D"),
            new FileHeader(FileType.Image, "img", "00 01 00 08 00 01 00 01 01"),
            new FileHeader(FileType.Image, "img", "50 49 43 54 00 08"),
            new FileHeader(FileType.Image, "img", "53 43 4D 49"),
            new FileHeader(FileType.Image, "pic", "01 00 00 00 01"),
            new FileHeader(FileType.Image, "png", "89 50 4E 47 0D 0A 1A 0A"),
            new FileHeader(FileType.Image, "tif", "49 44 33"),
            new FileHeader(FileType.Image, "tif", "49 49 2A 00"),
            new FileHeader(FileType.Image, "tif", "4D 4D 00 2A"),
            new FileHeader(FileType.Image, "tif", "4D 4D 00 2B"),

            new FileHeader(FileType.Swf, "swf", "46 57 53"),    //FWS - uncompressed SWF
            new FileHeader(FileType.Swf, "swf", "43 57 53"),    //CWS - compressed SWF by using the ZLIB open standard
            new FileHeader(FileType.Swf, "swf", "5A 57 53"),    //ZWS - compressed SWF by using the LZMA open standard

            new FileHeader(FileType.Video, "flv", "46 4C 56 01"),
            new FileHeader(FileType.Video, "3gp", "00 00 00 ?? 66 74 79 70 33 67 70"),
            new FileHeader(FileType.Video, "mp4", "00 00 00 18 66 74 79 70 33 67 70 35"),
            new FileHeader(FileType.Video, "mov", "00 00 00 20 66 74 79 70 4D 34 41 20 00 00 00 00"),
            new FileHeader(FileType.Video, "mov", "6D 6F 6F 76"),
            new FileHeader(FileType.Video, "mov", "66 72 65 65"),
            new FileHeader(FileType.Video, "mov", "6D 64 61 74"),
            new FileHeader(FileType.Video, "mov", "77 69 64 65"),
            new FileHeader(FileType.Video, "mov", "70 6E 6F 74"),
            new FileHeader(FileType.Video, "mov", "73 6B 69 70"),
            new FileHeader(FileType.Video, "mpg", "00 00 01 B?"),
            new FileHeader(FileType.Video, "mpg", "00 00 00 ?? 66"),
            new FileHeader(FileType.Video, "wmf", "01 00 09 00 00 03"),
            new FileHeader(FileType.Video, "wmv", "30 26 B2 75 8E 66 CF 11 A6 D9 00 AA 00 62 CE 6C"),
            new FileHeader(FileType.Video, "avi", "52 49 46 46 ?? ?? ?? ?? 41 56 49 20 4C 49 53 54"),
        };
    }
}