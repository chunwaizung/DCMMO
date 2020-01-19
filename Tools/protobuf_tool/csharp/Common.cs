// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Common.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Dcgameprotobuf {

  /// <summary>Holder for reflection information generated from Common.proto</summary>
  public static partial class CommonReflection {

    #region Descriptor
    /// <summary>File descriptor for Common.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CommonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgxDb21tb24ucHJvdG8SDmRjZ2FtZXByb3RvYnVmIkoKCEVycm9yUmVzEgoK",
            "Am5vGAEgASgFEiUKBm9wQ29kZRgCIAEoDjIVLmRjZ2FtZXByb3RvYnVmLlR4",
            "dE9wEgsKA21zZxgDIAEoCSorCgVUeHRPcBINCglVTklWRVJTQUwQABIKCgZ0",
            "eHRNc2cQARIHCgNsdWEQAmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Dcgameprotobuf.TxtOp), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Dcgameprotobuf.ErrorRes), global::Dcgameprotobuf.ErrorRes.Parser, new[]{ "No", "OpCode", "Msg" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum TxtOp {
    [pbr::OriginalName("UNIVERSAL")] Universal = 0,
    [pbr::OriginalName("txtMsg")] TxtMsg = 1,
    [pbr::OriginalName("lua")] Lua = 2,
  }

  #endregion

  #region Messages
  /// <summary>
  ///1000001
  /// </summary>
  public sealed partial class ErrorRes : pb::IMessage<ErrorRes> {
    private static readonly pb::MessageParser<ErrorRes> _parser = new pb::MessageParser<ErrorRes>(() => new ErrorRes());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ErrorRes> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Dcgameprotobuf.CommonReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ErrorRes() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ErrorRes(ErrorRes other) : this() {
      no_ = other.no_;
      opCode_ = other.opCode_;
      msg_ = other.msg_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ErrorRes Clone() {
      return new ErrorRes(this);
    }

    /// <summary>Field number for the "no" field.</summary>
    public const int NoFieldNumber = 1;
    private int no_;
    /// <summary>
    ///错误
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int No {
      get { return no_; }
      set {
        no_ = value;
      }
    }

    /// <summary>Field number for the "opCode" field.</summary>
    public const int OpCodeFieldNumber = 2;
    private global::Dcgameprotobuf.TxtOp opCode_ = global::Dcgameprotobuf.TxtOp.Universal;
    /// <summary>
    ///操作方式
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Dcgameprotobuf.TxtOp OpCode {
      get { return opCode_; }
      set {
        opCode_ = value;
      }
    }

    /// <summary>Field number for the "msg" field.</summary>
    public const int MsgFieldNumber = 3;
    private string msg_ = "";
    /// <summary>
    ///文本，可以当消息，可以当lua脚本
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Msg {
      get { return msg_; }
      set {
        msg_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ErrorRes);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ErrorRes other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (No != other.No) return false;
      if (OpCode != other.OpCode) return false;
      if (Msg != other.Msg) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (No != 0) hash ^= No.GetHashCode();
      if (OpCode != global::Dcgameprotobuf.TxtOp.Universal) hash ^= OpCode.GetHashCode();
      if (Msg.Length != 0) hash ^= Msg.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (No != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(No);
      }
      if (OpCode != global::Dcgameprotobuf.TxtOp.Universal) {
        output.WriteRawTag(16);
        output.WriteEnum((int) OpCode);
      }
      if (Msg.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Msg);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (No != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(No);
      }
      if (OpCode != global::Dcgameprotobuf.TxtOp.Universal) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) OpCode);
      }
      if (Msg.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Msg);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ErrorRes other) {
      if (other == null) {
        return;
      }
      if (other.No != 0) {
        No = other.No;
      }
      if (other.OpCode != global::Dcgameprotobuf.TxtOp.Universal) {
        OpCode = other.OpCode;
      }
      if (other.Msg.Length != 0) {
        Msg = other.Msg;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            No = input.ReadInt32();
            break;
          }
          case 16: {
            OpCode = (global::Dcgameprotobuf.TxtOp) input.ReadEnum();
            break;
          }
          case 26: {
            Msg = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
