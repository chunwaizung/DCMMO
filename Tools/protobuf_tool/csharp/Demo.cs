// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Demo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Dcgameprotobuf {

  /// <summary>Holder for reflection information generated from Demo.proto</summary>
  public static partial class DemoReflection {

    #region Descriptor
    /// <summary>File descriptor for Demo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DemoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgpEZW1vLnByb3RvEg5kY2dhbWVwcm90b2J1ZiIeCgtQRGVtb1N0clJlcRIP",
            "Cgdjb250ZW50GAEgASgJIh4KC1BEZW1vU3RyUmVzEg8KB2NvbnRlbnQYASAB",
            "KAkiaQoIUFRlc3RNYXASMAoEZGF0YRgBIAMoCzIiLmRjZ2FtZXByb3RvYnVm",
            "LlBUZXN0TWFwLkRhdGFFbnRyeRorCglEYXRhRW50cnkSCwoDa2V5GAEgASgF",
            "Eg0KBXZhbHVlGAIgASgFOgI4ASIgCghQRGVtb0NscxIJCgFhGAEgASgFEgkK",
            "AWIYAiABKAkiQwoPUFRlc3REZW1vQ2xzUmVxEgoKAmYwGAEgASgFEiQKAmYx",
            "GAIgASgLMhguZGNnYW1lcHJvdG9idWYuUERlbW9DbHNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Dcgameprotobuf.PDemoStrReq), global::Dcgameprotobuf.PDemoStrReq.Parser, new[]{ "Content" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Dcgameprotobuf.PDemoStrRes), global::Dcgameprotobuf.PDemoStrRes.Parser, new[]{ "Content" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Dcgameprotobuf.PTestMap), global::Dcgameprotobuf.PTestMap.Parser, new[]{ "Data" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, }),
            new pbr::GeneratedClrTypeInfo(typeof(global::Dcgameprotobuf.PDemoCls), global::Dcgameprotobuf.PDemoCls.Parser, new[]{ "A", "B" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Dcgameprotobuf.PTestDemoClsReq), global::Dcgameprotobuf.PTestDemoClsReq.Parser, new[]{ "F0", "F1" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///2000001
  /// </summary>
  public sealed partial class PDemoStrReq : pb::IMessage<PDemoStrReq> {
    private static readonly pb::MessageParser<PDemoStrReq> _parser = new pb::MessageParser<PDemoStrReq>(() => new PDemoStrReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PDemoStrReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Dcgameprotobuf.DemoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PDemoStrReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PDemoStrReq(PDemoStrReq other) : this() {
      content_ = other.content_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PDemoStrReq Clone() {
      return new PDemoStrReq(this);
    }

    /// <summary>Field number for the "content" field.</summary>
    public const int ContentFieldNumber = 1;
    private string content_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Content {
      get { return content_; }
      set {
        content_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PDemoStrReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PDemoStrReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Content != other.Content) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Content.Length != 0) hash ^= Content.GetHashCode();
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
      if (Content.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Content);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Content.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Content);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PDemoStrReq other) {
      if (other == null) {
        return;
      }
      if (other.Content.Length != 0) {
        Content = other.Content;
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
            Content = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///2000002
  /// </summary>
  public sealed partial class PDemoStrRes : pb::IMessage<PDemoStrRes> {
    private static readonly pb::MessageParser<PDemoStrRes> _parser = new pb::MessageParser<PDemoStrRes>(() => new PDemoStrRes());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PDemoStrRes> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Dcgameprotobuf.DemoReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PDemoStrRes() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PDemoStrRes(PDemoStrRes other) : this() {
      content_ = other.content_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PDemoStrRes Clone() {
      return new PDemoStrRes(this);
    }

    /// <summary>Field number for the "content" field.</summary>
    public const int ContentFieldNumber = 1;
    private string content_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Content {
      get { return content_; }
      set {
        content_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PDemoStrRes);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PDemoStrRes other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Content != other.Content) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Content.Length != 0) hash ^= Content.GetHashCode();
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
      if (Content.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Content);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Content.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Content);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PDemoStrRes other) {
      if (other == null) {
        return;
      }
      if (other.Content.Length != 0) {
        Content = other.Content;
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
            Content = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class PTestMap : pb::IMessage<PTestMap> {
    private static readonly pb::MessageParser<PTestMap> _parser = new pb::MessageParser<PTestMap>(() => new PTestMap());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PTestMap> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Dcgameprotobuf.DemoReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PTestMap() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PTestMap(PTestMap other) : this() {
      data_ = other.data_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PTestMap Clone() {
      return new PTestMap(this);
    }

    /// <summary>Field number for the "data" field.</summary>
    public const int DataFieldNumber = 1;
    private static readonly pbc::MapField<int, int>.Codec _map_data_codec
        = new pbc::MapField<int, int>.Codec(pb::FieldCodec.ForInt32(8, 0), pb::FieldCodec.ForInt32(16, 0), 10);
    private readonly pbc::MapField<int, int> data_ = new pbc::MapField<int, int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<int, int> Data {
      get { return data_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PTestMap);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PTestMap other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!Data.Equals(other.Data)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= Data.GetHashCode();
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
      data_.WriteTo(output, _map_data_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += data_.CalculateSize(_map_data_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PTestMap other) {
      if (other == null) {
        return;
      }
      data_.Add(other.data_);
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
            data_.AddEntriesFrom(input, _map_data_codec);
            break;
          }
        }
      }
    }

  }

  public sealed partial class PDemoCls : pb::IMessage<PDemoCls> {
    private static readonly pb::MessageParser<PDemoCls> _parser = new pb::MessageParser<PDemoCls>(() => new PDemoCls());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PDemoCls> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Dcgameprotobuf.DemoReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PDemoCls() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PDemoCls(PDemoCls other) : this() {
      a_ = other.a_;
      b_ = other.b_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PDemoCls Clone() {
      return new PDemoCls(this);
    }

    /// <summary>Field number for the "a" field.</summary>
    public const int AFieldNumber = 1;
    private int a_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int A {
      get { return a_; }
      set {
        a_ = value;
      }
    }

    /// <summary>Field number for the "b" field.</summary>
    public const int BFieldNumber = 2;
    private string b_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string B {
      get { return b_; }
      set {
        b_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PDemoCls);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PDemoCls other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (A != other.A) return false;
      if (B != other.B) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (A != 0) hash ^= A.GetHashCode();
      if (B.Length != 0) hash ^= B.GetHashCode();
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
      if (A != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(A);
      }
      if (B.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(B);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (A != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(A);
      }
      if (B.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(B);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PDemoCls other) {
      if (other == null) {
        return;
      }
      if (other.A != 0) {
        A = other.A;
      }
      if (other.B.Length != 0) {
        B = other.B;
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
            A = input.ReadInt32();
            break;
          }
          case 18: {
            B = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///2000003
  /// </summary>
  public sealed partial class PTestDemoClsReq : pb::IMessage<PTestDemoClsReq> {
    private static readonly pb::MessageParser<PTestDemoClsReq> _parser = new pb::MessageParser<PTestDemoClsReq>(() => new PTestDemoClsReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PTestDemoClsReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Dcgameprotobuf.DemoReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PTestDemoClsReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PTestDemoClsReq(PTestDemoClsReq other) : this() {
      f0_ = other.f0_;
      f1_ = other.f1_ != null ? other.f1_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PTestDemoClsReq Clone() {
      return new PTestDemoClsReq(this);
    }

    /// <summary>Field number for the "f0" field.</summary>
    public const int F0FieldNumber = 1;
    private int f0_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int F0 {
      get { return f0_; }
      set {
        f0_ = value;
      }
    }

    /// <summary>Field number for the "f1" field.</summary>
    public const int F1FieldNumber = 2;
    private global::Dcgameprotobuf.PDemoCls f1_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Dcgameprotobuf.PDemoCls F1 {
      get { return f1_; }
      set {
        f1_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PTestDemoClsReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PTestDemoClsReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (F0 != other.F0) return false;
      if (!object.Equals(F1, other.F1)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (F0 != 0) hash ^= F0.GetHashCode();
      if (f1_ != null) hash ^= F1.GetHashCode();
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
      if (F0 != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(F0);
      }
      if (f1_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(F1);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (F0 != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(F0);
      }
      if (f1_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(F1);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PTestDemoClsReq other) {
      if (other == null) {
        return;
      }
      if (other.F0 != 0) {
        F0 = other.F0;
      }
      if (other.f1_ != null) {
        if (f1_ == null) {
          F1 = new global::Dcgameprotobuf.PDemoCls();
        }
        F1.MergeFrom(other.F1);
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
            F0 = input.ReadInt32();
            break;
          }
          case 18: {
            if (f1_ == null) {
              F1 = new global::Dcgameprotobuf.PDemoCls();
            }
            input.ReadMessage(F1);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
