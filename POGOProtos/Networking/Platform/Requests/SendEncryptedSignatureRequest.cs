// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Networking/Platform/Requests/SendEncryptedSignatureRequest.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Platform.Requests {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Platform/Requests/SendEncryptedSignatureRequest.proto</summary>
  public static partial class SendEncryptedSignatureRequestReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Platform/Requests/SendEncryptedSignatureRequest.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SendEncryptedSignatureRequestReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CktQT0dPUHJvdG9zL05ldHdvcmtpbmcvUGxhdGZvcm0vUmVxdWVzdHMvU2Vu",
            "ZEVuY3J5cHRlZFNpZ25hdHVyZVJlcXVlc3QucHJvdG8SJ1BPR09Qcm90b3Mu",
            "TmV0d29ya2luZy5QbGF0Zm9ybS5SZXF1ZXN0cyI8Ch1TZW5kRW5jcnlwdGVk",
            "U2lnbmF0dXJlUmVxdWVzdBIbChNlbmNyeXB0ZWRfc2lnbmF0dXJlGAEgASgM",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Platform.Requests.SendEncryptedSignatureRequest), global::POGOProtos.Networking.Platform.Requests.SendEncryptedSignatureRequest.Parser, new[]{ "EncryptedSignature" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class SendEncryptedSignatureRequest : pb::IMessage<SendEncryptedSignatureRequest> {
    private static readonly pb::MessageParser<SendEncryptedSignatureRequest> _parser = new pb::MessageParser<SendEncryptedSignatureRequest>(() => new SendEncryptedSignatureRequest());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SendEncryptedSignatureRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Platform.Requests.SendEncryptedSignatureRequestReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SendEncryptedSignatureRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SendEncryptedSignatureRequest(SendEncryptedSignatureRequest other) : this() {
      encryptedSignature_ = other.encryptedSignature_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SendEncryptedSignatureRequest Clone() {
      return new SendEncryptedSignatureRequest(this);
    }

    /// <summary>Field number for the "encrypted_signature" field.</summary>
    public const int EncryptedSignatureFieldNumber = 1;
    private pb::ByteString encryptedSignature_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString EncryptedSignature {
      get { return encryptedSignature_; }
      set {
        encryptedSignature_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SendEncryptedSignatureRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SendEncryptedSignatureRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EncryptedSignature != other.EncryptedSignature) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (EncryptedSignature.Length != 0) hash ^= EncryptedSignature.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (EncryptedSignature.Length != 0) {
        output.WriteRawTag(10);
        output.WriteBytes(EncryptedSignature);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (EncryptedSignature.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(EncryptedSignature);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SendEncryptedSignatureRequest other) {
      if (other == null) {
        return;
      }
      if (other.EncryptedSignature.Length != 0) {
        EncryptedSignature = other.EncryptedSignature;
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
            EncryptedSignature = input.ReadBytes();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
