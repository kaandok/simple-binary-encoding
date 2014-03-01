/* Generated SBE (Simple Binary Encoding) message codec */

#pragma warning disable 1591 // disable warning on missing comments
using System;
using Adaptive.SimpleBinaryEncoding;

namespace Adaptive.SimpleBinaryEncoding.Examples.Generated
{
    public class MessageHeader
    {
        private DirectBuffer _buffer;
        private int _offset;
        private int _actingVersion;

        public void Wrap(DirectBuffer buffer, int offset, int actingVersion)
        {
            _offset = offset;
            _actingVersion = actingVersion;
            _buffer = buffer;
        }

        public const int Size = 8;

    public const ushort BlockLengthNullValue = (ushort)65535;

    public const ushort BlockLengthMinValue = (ushort)0;

    public const ushort BlockLengthMaxValue = (ushort)65534;

    public ushort BlockLength
    {
        get
        {
            return _buffer.Uint16GetLittleEndian(_offset + 0);
        }
        set
        {
            _buffer.Uint16PutLittleEndian(_offset + 0, value);
        }
    }


    public const ushort TemplateIdNullValue = (ushort)65535;

    public const ushort TemplateIdMinValue = (ushort)0;

    public const ushort TemplateIdMaxValue = (ushort)65534;

    public ushort TemplateId
    {
        get
        {
            return _buffer.Uint16GetLittleEndian(_offset + 2);
        }
        set
        {
            _buffer.Uint16PutLittleEndian(_offset + 2, value);
        }
    }


    public const ushort SchemaIdNullValue = (ushort)65535;

    public const ushort SchemaIdMinValue = (ushort)0;

    public const ushort SchemaIdMaxValue = (ushort)65534;

    public ushort SchemaId
    {
        get
        {
            return _buffer.Uint16GetLittleEndian(_offset + 4);
        }
        set
        {
            _buffer.Uint16PutLittleEndian(_offset + 4, value);
        }
    }


    public const byte VersionNullValue = (byte)255;

    public const byte VersionMinValue = (byte)0;

    public const byte VersionMaxValue = (byte)254;

    public byte Version
    {
        get
        {
            return _buffer.Uint8Get(_offset + 6);
        }
        set
        {
            _buffer.Uint8Put(_offset + 6, value);
        }
    }


    public const byte ReservedNullValue = (byte)255;

    public const byte ReservedMinValue = (byte)0;

    public const byte ReservedMaxValue = (byte)254;

    public byte Reserved
    {
        get
        {
            return _buffer.Uint8Get(_offset + 7);
        }
        set
        {
            _buffer.Uint8Put(_offset + 7, value);
        }
    }

    }
}
