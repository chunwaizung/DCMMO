// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Player.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Dcgameprotobuf {

  /// <summary>Holder for reflection information generated from Player.proto</summary>
  public static partial class PlayerReflection {

    #region Descriptor
    /// <summary>File descriptor for Player.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgxQbGF5ZXIucHJvdG8SDmRjZ2FtZXByb3RvYnVmIhwKB1JvbGVSZXESEQoJ",
            "dXNlclRva2VuGAEgASgJIl0KCFJvbGVJbmZvEgwKBG5hbWUYASABKAkSJAoD",
            "am9iGAIgASgOMhcuZGNnYW1lcHJvdG9idWYuSm9iVHlwZRINCgVsZXZlbBgD",
            "IAEoBRIOCgZyb2xlSWQYBCABKAUiQwoHUm9sZVJlcxIPCgdlcnJvck5vGAEg",
            "ASgFEicKBWluZm9zGAIgAygLMhguZGNnYW1lcHJvdG9idWYuUm9sZUluZm8i",
            "HQoLTG9naW5TdnJSZXESDgoGcm9sZUlkGAEgASgFIhwKC0xvZ2luU3ZyUmVz",
            "Eg0KBWVycm9yGAEgASgIIjIKCkFkZFJvbGVSZXESJAoDam9iGAEgASgOMhcu",
            "ZGNnYW1lcHJvdG9idWYuSm9iVHlwZSIbCgpBZGRSb2xlUmVzEg0KBWVycm9y",
            "GAEgASgIKi4KB0pvYlR5cGUSDQoJVU5JVkVSU0FMEAASCQoFU2FiZXIQARIJ",
            "CgVNYWdpYxACYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Dcgameprotobuf.JobType), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Dcgameprotobuf.RoleReq), global::Dcgameprotobuf.RoleReq.Parser, new[]{ "UserToken" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Dcgameprotobuf.RoleInfo), global::Dcgameprotobuf.RoleInfo.Parser, new[]{ "Name", "Job", "Level", "RoleId" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Dcgameprotobuf.RoleRes), global::Dcgameprotobuf.RoleRes.Parser, new[]{ "ErrorNo", "Infos" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Dcgameprotobuf.LoginSvrReq), global::Dcgameprotobuf.LoginSvrReq.Parser, new[]{ "RoleId" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Dcgameprotobuf.LoginSvrRes), global::Dcgameprotobuf.LoginSvrRes.Parser, new[]{ "Error" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Dcgameprotobuf.AddRoleReq), global::Dcgameprotobuf.AddRoleReq.Parser, new[]{ "Job" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Dcgameprotobuf.AddRoleRes), global::Dcgameprotobuf.AddRoleRes.Parser, new[]{ "Error" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum JobType {
    [pbr::OriginalName("UNIVERSAL")] Universal = 0,
    [pbr::OriginalName("Saber")] Saber = 1,
    [pbr::OriginalName("Magic")] Magic = 2,
  }

  #endregion

  #region Messages
  /// <summary>
  ///请求角色列表
  ///1010001
  /// </summary>
  public sealed partial class RoleReq : pb::IMessage<RoleReq> {
    private static readonly pb::MessageParser<RoleReq> _parser = new pb::MessageParser<RoleReq>(() => new RoleReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RoleReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Dcgameprotobuf.PlayerReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoleReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoleReq(RoleReq other) : this() {
      userToken_ = other.userToken_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoleReq Clone() {
      return new RoleReq(this);
    }

    /// <summary>Field number for the "userToken" field.</summary>
    public const int UserTokenFieldNumber = 1;
    private string userToken_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string UserToken {
      get { return userToken_; }
      set {
        userToken_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RoleReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RoleReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (UserToken != other.UserToken) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (UserToken.Length != 0) hash ^= UserToken.GetHashCode();
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
      if (UserToken.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(UserToken);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (UserToken.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(UserToken);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RoleReq other) {
      if (other == null) {
        return;
      }
      if (other.UserToken.Length != 0) {
        UserToken = other.UserToken;
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
          case 10: {
            UserToken = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class RoleInfo : pb::IMessage<RoleInfo> {
    private static readonly pb::MessageParser<RoleInfo> _parser = new pb::MessageParser<RoleInfo>(() => new RoleInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RoleInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Dcgameprotobuf.PlayerReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoleInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoleInfo(RoleInfo other) : this() {
      name_ = other.name_;
      job_ = other.job_;
      level_ = other.level_;
      roleId_ = other.roleId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoleInfo Clone() {
      return new RoleInfo(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "job" field.</summary>
    public const int JobFieldNumber = 2;
    private global::Dcgameprotobuf.JobType job_ = global::Dcgameprotobuf.JobType.Universal;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Dcgameprotobuf.JobType Job {
      get { return job_; }
      set {
        job_ = value;
      }
    }

    /// <summary>Field number for the "level" field.</summary>
    public const int LevelFieldNumber = 3;
    private int level_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Level {
      get { return level_; }
      set {
        level_ = value;
      }
    }

    /// <summary>Field number for the "roleId" field.</summary>
    public const int RoleIdFieldNumber = 4;
    private int roleId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int RoleId {
      get { return roleId_; }
      set {
        roleId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RoleInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RoleInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Job != other.Job) return false;
      if (Level != other.Level) return false;
      if (RoleId != other.RoleId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Job != global::Dcgameprotobuf.JobType.Universal) hash ^= Job.GetHashCode();
      if (Level != 0) hash ^= Level.GetHashCode();
      if (RoleId != 0) hash ^= RoleId.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Job != global::Dcgameprotobuf.JobType.Universal) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Job);
      }
      if (Level != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Level);
      }
      if (RoleId != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(RoleId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Job != global::Dcgameprotobuf.JobType.Universal) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Job);
      }
      if (Level != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Level);
      }
      if (RoleId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(RoleId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RoleInfo other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Job != global::Dcgameprotobuf.JobType.Universal) {
        Job = other.Job;
      }
      if (other.Level != 0) {
        Level = other.Level;
      }
      if (other.RoleId != 0) {
        RoleId = other.RoleId;
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
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 16: {
            Job = (global::Dcgameprotobuf.JobType) input.ReadEnum();
            break;
          }
          case 24: {
            Level = input.ReadInt32();
            break;
          }
          case 32: {
            RoleId = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///1010002
  /// </summary>
  public sealed partial class RoleRes : pb::IMessage<RoleRes> {
    private static readonly pb::MessageParser<RoleRes> _parser = new pb::MessageParser<RoleRes>(() => new RoleRes());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<RoleRes> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Dcgameprotobuf.PlayerReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoleRes() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoleRes(RoleRes other) : this() {
      errorNo_ = other.errorNo_;
      infos_ = other.infos_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public RoleRes Clone() {
      return new RoleRes(this);
    }

    /// <summary>Field number for the "errorNo" field.</summary>
    public const int ErrorNoFieldNumber = 1;
    private int errorNo_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ErrorNo {
      get { return errorNo_; }
      set {
        errorNo_ = value;
      }
    }

    /// <summary>Field number for the "infos" field.</summary>
    public const int InfosFieldNumber = 2;
    private static readonly pb::FieldCodec<global::Dcgameprotobuf.RoleInfo> _repeated_infos_codec
        = pb::FieldCodec.ForMessage(18, global::Dcgameprotobuf.RoleInfo.Parser);
    private readonly pbc::RepeatedField<global::Dcgameprotobuf.RoleInfo> infos_ = new pbc::RepeatedField<global::Dcgameprotobuf.RoleInfo>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Dcgameprotobuf.RoleInfo> Infos {
      get { return infos_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as RoleRes);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(RoleRes other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ErrorNo != other.ErrorNo) return false;
      if(!infos_.Equals(other.infos_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ErrorNo != 0) hash ^= ErrorNo.GetHashCode();
      hash ^= infos_.GetHashCode();
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
      if (ErrorNo != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(ErrorNo);
      }
      infos_.WriteTo(output, _repeated_infos_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ErrorNo != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ErrorNo);
      }
      size += infos_.CalculateSize(_repeated_infos_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(RoleRes other) {
      if (other == null) {
        return;
      }
      if (other.ErrorNo != 0) {
        ErrorNo = other.ErrorNo;
      }
      infos_.Add(other.infos_);
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
            ErrorNo = input.ReadInt32();
            break;
          }
          case 18: {
            infos_.AddEntriesFrom(input, _repeated_infos_codec);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///登录游戏服务器发送获得的roleToken用来定位当前登录的角色
  ///1010003
  /// </summary>
  public sealed partial class LoginSvrReq : pb::IMessage<LoginSvrReq> {
    private static readonly pb::MessageParser<LoginSvrReq> _parser = new pb::MessageParser<LoginSvrReq>(() => new LoginSvrReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<LoginSvrReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Dcgameprotobuf.PlayerReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LoginSvrReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LoginSvrReq(LoginSvrReq other) : this() {
      roleId_ = other.roleId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LoginSvrReq Clone() {
      return new LoginSvrReq(this);
    }

    /// <summary>Field number for the "roleId" field.</summary>
    public const int RoleIdFieldNumber = 1;
    private int roleId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int RoleId {
      get { return roleId_; }
      set {
        roleId_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as LoginSvrReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(LoginSvrReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (RoleId != other.RoleId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (RoleId != 0) hash ^= RoleId.GetHashCode();
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
      if (RoleId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(RoleId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (RoleId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(RoleId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(LoginSvrReq other) {
      if (other == null) {
        return;
      }
      if (other.RoleId != 0) {
        RoleId = other.RoleId;
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
            RoleId = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///登录成功
  ///1010004
  /// </summary>
  public sealed partial class LoginSvrRes : pb::IMessage<LoginSvrRes> {
    private static readonly pb::MessageParser<LoginSvrRes> _parser = new pb::MessageParser<LoginSvrRes>(() => new LoginSvrRes());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<LoginSvrRes> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Dcgameprotobuf.PlayerReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LoginSvrRes() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LoginSvrRes(LoginSvrRes other) : this() {
      error_ = other.error_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public LoginSvrRes Clone() {
      return new LoginSvrRes(this);
    }

    /// <summary>Field number for the "error" field.</summary>
    public const int ErrorFieldNumber = 1;
    private bool error_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Error {
      get { return error_; }
      set {
        error_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as LoginSvrRes);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(LoginSvrRes other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Error != other.Error) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Error != false) hash ^= Error.GetHashCode();
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
      if (Error != false) {
        output.WriteRawTag(8);
        output.WriteBool(Error);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Error != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(LoginSvrRes other) {
      if (other == null) {
        return;
      }
      if (other.Error != false) {
        Error = other.Error;
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
            Error = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///添加角色
  ///1010005
  /// </summary>
  public sealed partial class AddRoleReq : pb::IMessage<AddRoleReq> {
    private static readonly pb::MessageParser<AddRoleReq> _parser = new pb::MessageParser<AddRoleReq>(() => new AddRoleReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AddRoleReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Dcgameprotobuf.PlayerReflection.Descriptor.MessageTypes[5]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddRoleReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddRoleReq(AddRoleReq other) : this() {
      job_ = other.job_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddRoleReq Clone() {
      return new AddRoleReq(this);
    }

    /// <summary>Field number for the "job" field.</summary>
    public const int JobFieldNumber = 1;
    private global::Dcgameprotobuf.JobType job_ = global::Dcgameprotobuf.JobType.Universal;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Dcgameprotobuf.JobType Job {
      get { return job_; }
      set {
        job_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AddRoleReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AddRoleReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Job != other.Job) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Job != global::Dcgameprotobuf.JobType.Universal) hash ^= Job.GetHashCode();
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
      if (Job != global::Dcgameprotobuf.JobType.Universal) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Job);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Job != global::Dcgameprotobuf.JobType.Universal) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Job);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AddRoleReq other) {
      if (other == null) {
        return;
      }
      if (other.Job != global::Dcgameprotobuf.JobType.Universal) {
        Job = other.Job;
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
            Job = (global::Dcgameprotobuf.JobType) input.ReadEnum();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///添加角色
  ///1010006
  /// </summary>
  public sealed partial class AddRoleRes : pb::IMessage<AddRoleRes> {
    private static readonly pb::MessageParser<AddRoleRes> _parser = new pb::MessageParser<AddRoleRes>(() => new AddRoleRes());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AddRoleRes> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Dcgameprotobuf.PlayerReflection.Descriptor.MessageTypes[6]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddRoleRes() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddRoleRes(AddRoleRes other) : this() {
      error_ = other.error_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AddRoleRes Clone() {
      return new AddRoleRes(this);
    }

    /// <summary>Field number for the "error" field.</summary>
    public const int ErrorFieldNumber = 1;
    private bool error_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Error {
      get { return error_; }
      set {
        error_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AddRoleRes);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AddRoleRes other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Error != other.Error) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Error != false) hash ^= Error.GetHashCode();
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
      if (Error != false) {
        output.WriteRawTag(8);
        output.WriteBool(Error);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Error != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AddRoleRes other) {
      if (other == null) {
        return;
      }
      if (other.Error != false) {
        Error = other.Error;
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
            Error = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
