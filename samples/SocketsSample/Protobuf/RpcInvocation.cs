// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: RpcInvocation.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from RpcInvocation.proto</summary>
public static partial class RpcInvocationReflection {

  #region Descriptor
  /// <summary>File descriptor for RpcInvocation.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static RpcInvocationReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChNScGNJbnZvY2F0aW9uLnByb3RvIl8KDlJwY01lc3NhZ2VLaW5kEikKC01l",
          "c3NhZ2VLaW5kGAEgASgOMhQuUnBjTWVzc2FnZUtpbmQuS2luZCIiCgRLaW5k",
          "EgoKBlJlc3VsdBAAEg4KCkludm9jYXRpb24QASJAChNScGNJbnZvY2F0aW9u",
          "SGVhZGVyEgwKBE5hbWUYASABKAkSCgoCSWQYAiABKAUSDwoHTnVtQXJncxgD",
          "IAEoBSJJChlScGNJbnZvY2F0aW9uUmVzdWx0SGVhZGVyEgoKAklkGAEgASgF",
          "EhEKCUhhc1Jlc3VsdBgCIAEoCBINCgVFcnJvchgDIAEoCSJHCg5QcmltaXRp",
          "dmVWYWx1ZRIUCgpJbnQzMlZhbHVlGAEgASgFSAASFQoLU3RyaW5nVmFsdWUY",
          "AiABKAlIAEIICgZvbmVvZl9iBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::RpcMessageKind), global::RpcMessageKind.Parser, new[]{ "MessageKind" }, null, new[]{ typeof(global::RpcMessageKind.Types.Kind) }, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::RpcInvocationHeader), global::RpcInvocationHeader.Parser, new[]{ "Name", "Id", "NumArgs" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::RpcInvocationResultHeader), global::RpcInvocationResultHeader.Parser, new[]{ "Id", "HasResult", "Error" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::PrimitiveValue), global::PrimitiveValue.Parser, new[]{ "Int32Value", "StringValue" }, new[]{ "Oneof" }, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class RpcMessageKind : pb::IMessage<RpcMessageKind> {
  private static readonly pb::MessageParser<RpcMessageKind> _parser = new pb::MessageParser<RpcMessageKind>(() => new RpcMessageKind());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<RpcMessageKind> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::RpcInvocationReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public RpcMessageKind() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public RpcMessageKind(RpcMessageKind other) : this() {
    messageKind_ = other.messageKind_;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public RpcMessageKind Clone() {
    return new RpcMessageKind(this);
  }

  /// <summary>Field number for the "MessageKind" field.</summary>
  public const int MessageKindFieldNumber = 1;
  private global::RpcMessageKind.Types.Kind messageKind_ = 0;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::RpcMessageKind.Types.Kind MessageKind {
    get { return messageKind_; }
    set {
      messageKind_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as RpcMessageKind);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(RpcMessageKind other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (MessageKind != other.MessageKind) return false;
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (MessageKind != 0) hash ^= MessageKind.GetHashCode();
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (MessageKind != 0) {
      output.WriteRawTag(8);
      output.WriteEnum((int) MessageKind);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (MessageKind != 0) {
      size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) MessageKind);
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(RpcMessageKind other) {
    if (other == null) {
      return;
    }
    if (other.MessageKind != 0) {
      MessageKind = other.MessageKind;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          input.SkipLastField();
          break;
        case 8: {
          messageKind_ = (global::RpcMessageKind.Types.Kind) input.ReadEnum();
          break;
        }
      }
    }
  }

  #region Nested types
  /// <summary>Container for nested types declared in the RpcMessageKind message type.</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static partial class Types {
    public enum Kind {
      [pbr::OriginalName("Result")] Result = 0,
      [pbr::OriginalName("Invocation")] Invocation = 1,
    }

  }
  #endregion

}

public sealed partial class RpcInvocationHeader : pb::IMessage<RpcInvocationHeader> {
  private static readonly pb::MessageParser<RpcInvocationHeader> _parser = new pb::MessageParser<RpcInvocationHeader>(() => new RpcInvocationHeader());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<RpcInvocationHeader> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::RpcInvocationReflection.Descriptor.MessageTypes[1]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public RpcInvocationHeader() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public RpcInvocationHeader(RpcInvocationHeader other) : this() {
    name_ = other.name_;
    id_ = other.id_;
    numArgs_ = other.numArgs_;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public RpcInvocationHeader Clone() {
    return new RpcInvocationHeader(this);
  }

  /// <summary>Field number for the "Name" field.</summary>
  public const int NameFieldNumber = 1;
  private string name_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Name {
    get { return name_; }
    set {
      name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "Id" field.</summary>
  public const int IdFieldNumber = 2;
  private int id_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int Id {
    get { return id_; }
    set {
      id_ = value;
    }
  }

  /// <summary>Field number for the "NumArgs" field.</summary>
  public const int NumArgsFieldNumber = 3;
  private int numArgs_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int NumArgs {
    get { return numArgs_; }
    set {
      numArgs_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as RpcInvocationHeader);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(RpcInvocationHeader other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Name != other.Name) return false;
    if (Id != other.Id) return false;
    if (NumArgs != other.NumArgs) return false;
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Name.Length != 0) hash ^= Name.GetHashCode();
    if (Id != 0) hash ^= Id.GetHashCode();
    if (NumArgs != 0) hash ^= NumArgs.GetHashCode();
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
    if (Id != 0) {
      output.WriteRawTag(16);
      output.WriteInt32(Id);
    }
    if (NumArgs != 0) {
      output.WriteRawTag(24);
      output.WriteInt32(NumArgs);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Name.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
    }
    if (Id != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
    }
    if (NumArgs != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(NumArgs);
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(RpcInvocationHeader other) {
    if (other == null) {
      return;
    }
    if (other.Name.Length != 0) {
      Name = other.Name;
    }
    if (other.Id != 0) {
      Id = other.Id;
    }
    if (other.NumArgs != 0) {
      NumArgs = other.NumArgs;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          input.SkipLastField();
          break;
        case 10: {
          Name = input.ReadString();
          break;
        }
        case 16: {
          Id = input.ReadInt32();
          break;
        }
        case 24: {
          NumArgs = input.ReadInt32();
          break;
        }
      }
    }
  }

}

public sealed partial class RpcInvocationResultHeader : pb::IMessage<RpcInvocationResultHeader> {
  private static readonly pb::MessageParser<RpcInvocationResultHeader> _parser = new pb::MessageParser<RpcInvocationResultHeader>(() => new RpcInvocationResultHeader());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<RpcInvocationResultHeader> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::RpcInvocationReflection.Descriptor.MessageTypes[2]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public RpcInvocationResultHeader() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public RpcInvocationResultHeader(RpcInvocationResultHeader other) : this() {
    id_ = other.id_;
    hasResult_ = other.hasResult_;
    error_ = other.error_;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public RpcInvocationResultHeader Clone() {
    return new RpcInvocationResultHeader(this);
  }

  /// <summary>Field number for the "Id" field.</summary>
  public const int IdFieldNumber = 1;
  private int id_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int Id {
    get { return id_; }
    set {
      id_ = value;
    }
  }

  /// <summary>Field number for the "HasResult" field.</summary>
  public const int HasResultFieldNumber = 2;
  private bool hasResult_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool HasResult {
    get { return hasResult_; }
    set {
      hasResult_ = value;
    }
  }

  /// <summary>Field number for the "Error" field.</summary>
  public const int ErrorFieldNumber = 3;
  private string error_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string Error {
    get { return error_; }
    set {
      error_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as RpcInvocationResultHeader);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(RpcInvocationResultHeader other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Id != other.Id) return false;
    if (HasResult != other.HasResult) return false;
    if (Error != other.Error) return false;
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Id != 0) hash ^= Id.GetHashCode();
    if (HasResult != false) hash ^= HasResult.GetHashCode();
    if (Error.Length != 0) hash ^= Error.GetHashCode();
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (Id != 0) {
      output.WriteRawTag(8);
      output.WriteInt32(Id);
    }
    if (HasResult != false) {
      output.WriteRawTag(16);
      output.WriteBool(HasResult);
    }
    if (Error.Length != 0) {
      output.WriteRawTag(26);
      output.WriteString(Error);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Id != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
    }
    if (HasResult != false) {
      size += 1 + 1;
    }
    if (Error.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(Error);
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(RpcInvocationResultHeader other) {
    if (other == null) {
      return;
    }
    if (other.Id != 0) {
      Id = other.Id;
    }
    if (other.HasResult != false) {
      HasResult = other.HasResult;
    }
    if (other.Error.Length != 0) {
      Error = other.Error;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          input.SkipLastField();
          break;
        case 8: {
          Id = input.ReadInt32();
          break;
        }
        case 16: {
          HasResult = input.ReadBool();
          break;
        }
        case 26: {
          Error = input.ReadString();
          break;
        }
      }
    }
  }

}

public sealed partial class PrimitiveValue : pb::IMessage<PrimitiveValue> {
  private static readonly pb::MessageParser<PrimitiveValue> _parser = new pb::MessageParser<PrimitiveValue>(() => new PrimitiveValue());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<PrimitiveValue> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::RpcInvocationReflection.Descriptor.MessageTypes[3]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public PrimitiveValue() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public PrimitiveValue(PrimitiveValue other) : this() {
    switch (other.OneofCase) {
      case OneofOneofCase.Int32Value:
        Int32Value = other.Int32Value;
        break;
      case OneofOneofCase.StringValue:
        StringValue = other.StringValue;
        break;
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public PrimitiveValue Clone() {
    return new PrimitiveValue(this);
  }

  /// <summary>Field number for the "Int32Value" field.</summary>
  public const int Int32ValueFieldNumber = 1;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int Int32Value {
    get { return oneofCase_ == OneofOneofCase.Int32Value ? (int) oneof_ : 0; }
    set {
      oneof_ = value;
      oneofCase_ = OneofOneofCase.Int32Value;
    }
  }

  /// <summary>Field number for the "StringValue" field.</summary>
  public const int StringValueFieldNumber = 2;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string StringValue {
    get { return oneofCase_ == OneofOneofCase.StringValue ? (string) oneof_ : ""; }
    set {
      oneof_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      oneofCase_ = OneofOneofCase.StringValue;
    }
  }

  private object oneof_;
  /// <summary>Enum of possible cases for the "oneof_" oneof.</summary>
  public enum OneofOneofCase {
    None = 0,
    Int32Value = 1,
    StringValue = 2,
  }
  private OneofOneofCase oneofCase_ = OneofOneofCase.None;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public OneofOneofCase OneofCase {
    get { return oneofCase_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void ClearOneof() {
    oneofCase_ = OneofOneofCase.None;
    oneof_ = null;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as PrimitiveValue);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(PrimitiveValue other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Int32Value != other.Int32Value) return false;
    if (StringValue != other.StringValue) return false;
    if (OneofCase != other.OneofCase) return false;
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (oneofCase_ == OneofOneofCase.Int32Value) hash ^= Int32Value.GetHashCode();
    if (oneofCase_ == OneofOneofCase.StringValue) hash ^= StringValue.GetHashCode();
    hash ^= (int) oneofCase_;
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (oneofCase_ == OneofOneofCase.Int32Value) {
      output.WriteRawTag(8);
      output.WriteInt32(Int32Value);
    }
    if (oneofCase_ == OneofOneofCase.StringValue) {
      output.WriteRawTag(18);
      output.WriteString(StringValue);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (oneofCase_ == OneofOneofCase.Int32Value) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Int32Value);
    }
    if (oneofCase_ == OneofOneofCase.StringValue) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(StringValue);
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(PrimitiveValue other) {
    if (other == null) {
      return;
    }
    switch (other.OneofCase) {
      case OneofOneofCase.Int32Value:
        Int32Value = other.Int32Value;
        break;
      case OneofOneofCase.StringValue:
        StringValue = other.StringValue;
        break;
    }

  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          input.SkipLastField();
          break;
        case 8: {
          Int32Value = input.ReadInt32();
          break;
        }
        case 18: {
          StringValue = input.ReadString();
          break;
        }
      }
    }
  }

}

#endregion


#endregion Designer generated code
