// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: CommonActor.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Dcgameprotobuf {

  /// <summary>Holder for reflection information generated from CommonActor.proto</summary>
  public static partial class CommonActorReflection {

    #region Descriptor
    /// <summary>File descriptor for CommonActor.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CommonActorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChFDb21tb25BY3Rvci5wcm90bxIOZGNnYW1lcHJvdG9idWYiJAoKUEFjdG9y",
            "RGF0YRIKCgJocBgBIAEoBRIKCgJtcBgCIAEoBSp2Cg5QQWN0b3JEYXRhVHlw",
            "ZRIKCgZtYXhfaHAQABIKCgZtYXhfbXAQARIGCgJtcBACEgYKAmhwEAMSDgoK",
            "cGh5c2ljX2F0axAEEg0KCW1hZ2ljX2F0axAFEg4KCnBoeXNpY19kZWYQBhIN",
            "CgltYWdpY19kZWYQB2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Dcgameprotobuf.PActorDataType), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Dcgameprotobuf.PActorData), global::Dcgameprotobuf.PActorData.Parser, new[]{ "Hp", "Mp" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum PActorDataType {
    [pbr::OriginalName("max_hp")] MaxHp = 0,
    [pbr::OriginalName("max_mp")] MaxMp = 1,
    [pbr::OriginalName("mp")] Mp = 2,
    [pbr::OriginalName("hp")] Hp = 3,
    [pbr::OriginalName("physic_atk")] PhysicAtk = 4,
    [pbr::OriginalName("magic_atk")] MagicAtk = 5,
    [pbr::OriginalName("physic_def")] PhysicDef = 6,
    [pbr::OriginalName("magic_def")] MagicDef = 7,
  }

  #endregion

  #region Messages
  public sealed partial class PActorData : pb::IMessage<PActorData> {
    private static readonly pb::MessageParser<PActorData> _parser = new pb::MessageParser<PActorData>(() => new PActorData());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PActorData> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Dcgameprotobuf.CommonActorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PActorData() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PActorData(PActorData other) : this() {
      hp_ = other.hp_;
      mp_ = other.mp_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PActorData Clone() {
      return new PActorData(this);
    }

    /// <summary>Field number for the "hp" field.</summary>
    public const int HpFieldNumber = 1;
    private int hp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Hp {
      get { return hp_; }
      set {
        hp_ = value;
      }
    }

    /// <summary>Field number for the "mp" field.</summary>
    public const int MpFieldNumber = 2;
    private int mp_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Mp {
      get { return mp_; }
      set {
        mp_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PActorData);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PActorData other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Hp != other.Hp) return false;
      if (Mp != other.Mp) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Hp != 0) hash ^= Hp.GetHashCode();
      if (Mp != 0) hash ^= Mp.GetHashCode();
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
      if (Hp != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Hp);
      }
      if (Mp != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Mp);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Hp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Hp);
      }
      if (Mp != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Mp);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PActorData other) {
      if (other == null) {
        return;
      }
      if (other.Hp != 0) {
        Hp = other.Hp;
      }
      if (other.Mp != 0) {
        Mp = other.Mp;
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
            Hp = input.ReadInt32();
            break;
          }
          case 16: {
            Mp = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
