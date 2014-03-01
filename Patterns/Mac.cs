﻿/*
 * Copyright (C) 2012-2013 Arctium Emulation <http://arctium.org>
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

namespace Connection_Patcher.Patterns
{
    class Mac
    {
        public static class x86
        {
            public static byte[] Send  = { 0x8B, 0x4D, 0xE0, 0x8B, 0x45, 0xD4, 0x89 };
            public static byte[] Email = { 0x74, 0x05, 0xBE, 0x01, 0x00, 0x00, 0x00, 0xA1 };
            public static byte[] User  = { 0x40, 0x00, 0x00, 0x00, 0xE8, 0x00, 0x00, 0x00, 0x00, 0x85, 0xC0, 0x0F, 0x84, 0x00, 0x00, 0x00, 0x00, 0xC7, 0x05, 0x00, 0x00, 0x00, 0x00, 0xFF };
            public static byte[] RaF   = { 0xA1, 0x00, 0x00, 0x00, 0x00, 0x8B, 0x08, 0x8B, 0x01, 0x89, 0x4C, 0x24, 0x04, 0x8D, 0x4D, 0xE0, 0x89, 0x0C, 0x24, 0xC7 };
        }

        public static class x64
        {
            public static byte[] Send  = { 0x8B, 0x00, 0x00, 0x45, 0x00, 0x00, 0x1C, 0x00, 0x00, 0x00, 0x14, 0x08 };
            public static byte[] Email = { 0x74, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x48, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x48, 0x00, 0x00, 0x74, 0x00, 0x48, 0x00, 0x00, 0xFF, 0x90 };
            public static byte[] User  = { 0x40, 0x00, 0x00, 0x00, 0xE8, 0x00, 0x00, 0x00, 0x00, 0x48, 0x00, 0x00, 0x0F, 0x84, 0x00, 0x00, 0x00, 0x00, 0xC7, 0x05, 0x00, 0x00, 0x00, 0x00, 0xFF, 0xFF, 0xFF, 0xFF };
            public static byte[] RaF   = { 0x48, 0x8D, 0x00, 0x00, 0x00, 0x00, 0x00, 0x48, 0x8D, 0x00, 0x00, 0x00, 0x00, 0x00, 0x48, 0x8D, 0x00, 0x00, 0x00, 0x00, 0x00, 0x48, 0x00, 0x00, 0x48, 0x00, 0x00, 0x31 };
        }
    }
}
