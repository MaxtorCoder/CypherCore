// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: bgs/low/pb/client/api/client/v2/report_types.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Bgs.Protocol.Report.V2 {

  /// <summary>Holder for reflection information generated from bgs/low/pb/client/api/client/v2/report_types.proto</summary>
  public static partial class ReportTypesReflection {

    #region Descriptor
    /// <summary>File descriptor for bgs/low/pb/client/api/client/v2/report_types.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ReportTypesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjJiZ3MvbG93L3BiL2NsaWVudC9hcGkvY2xpZW50L3YyL3JlcG9ydF90eXBl",
            "cy5wcm90bxIWYmdzLnByb3RvY29sLnJlcG9ydC52MholYmdzL2xvdy9wYi9j",
            "bGllbnQvYWNjb3VudF90eXBlcy5wcm90bxohYmdzL2xvdy9wYi9jbGllbnQv",
            "cnBjX3R5cGVzLnByb3RvGiViZ3MvbG93L3BiL2NsaWVudC9tZXNzYWdlX3R5",
            "cGVzLnByb3RvGjliZ3MvbG93L3BiL2NsaWVudC9nbG9iYWxfZXh0ZW5zaW9u",
            "cy9tZXNzYWdlX29wdGlvbnMucHJvdG8aN2Jncy9sb3cvcGIvY2xpZW50L2ds",
            "b2JhbF9leHRlbnNpb25zL2ZpZWxkX29wdGlvbnMucHJvdG8aOGJncy9sb3cv",
            "cGIvY2xpZW50L2dsb2JhbF9leHRlbnNpb25zL21ldGhvZF9vcHRpb25zLnBy",
            "b3RvGjliZ3MvbG93L3BiL2NsaWVudC9nbG9iYWxfZXh0ZW5zaW9ucy9zZXJ2",
            "aWNlX29wdGlvbnMucHJvdG8iQwoKUmVwb3J0SXRlbRItCgptZXNzYWdlX2lk",
            "GAEgASgLMhcuYmdzLnByb3RvY29sLk1lc3NhZ2VJZEgAQgYKBHR5cGUi/wEK",
            "C1VzZXJPcHRpb25zEjUKCXRhcmdldF9pZBgBIAEoCzIiLmJncy5wcm90b2Nv",
            "bC5hY2NvdW50LnYxLkFjY291bnRJZBJACgR0eXBlGAIgASgOMiEuYmdzLnBy",
            "b3RvY29sLnJlcG9ydC52Mi5Jc3N1ZVR5cGU6D0lTU1VFX1RZUEVfU1BBTRJF",
            "CgZzb3VyY2UYAyABKA4yIi5iZ3MucHJvdG9jb2wucmVwb3J0LnYyLlVzZXJT",
            "b3VyY2U6EVVTRVJfU09VUkNFX09USEVSEjAKBGl0ZW0YBCABKAsyIi5iZ3Mu",
            "cHJvdG9jb2wucmVwb3J0LnYyLlJlcG9ydEl0ZW0i7AEKC0NsdWJPcHRpb25z",
            "Eg8KB2NsdWJfaWQYASABKAQSEQoJc3RyZWFtX2lkGAIgASgEEkAKBHR5cGUY",
            "AyABKA4yIS5iZ3MucHJvdG9jb2wucmVwb3J0LnYyLklzc3VlVHlwZToPSVNT",
            "VUVfVFlQRV9TUEFNEkUKBnNvdXJjZRgEIAEoDjIiLmJncy5wcm90b2NvbC5y",
            "ZXBvcnQudjIuQ2x1YlNvdXJjZToRQ0xVQl9TT1VSQ0VfT1RIRVISMAoEaXRl",
            "bRgFIAEoCzIiLmJncy5wcm90b2NvbC5yZXBvcnQudjIuUmVwb3J0SXRlbSqN",
            "AQoJSXNzdWVUeXBlEhMKD0lTU1VFX1RZUEVfU1BBTRAAEhkKFUlTU1VFX1RZ",
            "UEVfSEFSQVNTTUVOVBABEiAKHElTU1VFX1RZUEVfT0ZGRU5TSVZFX0NPTlRF",
            "TlQQAxIWChJJU1NVRV9UWVBFX0hBQ0tJTkcQBBIWChJJU1NVRV9UWVBFX0JP",
            "VFRJTkcQBSrBAQoKVXNlclNvdXJjZRIVChFVU0VSX1NPVVJDRV9PVEhFUhAA",
            "EhcKE1VTRVJfU09VUkNFX1dISVNQRVIQARIXChNVU0VSX1NPVVJDRV9QUk9G",
            "SUxFEAISGgoWVVNFUl9TT1VSQ0VfQkFUVExFX1RBRxADEhQKEFVTRVJfU09V",
            "UkNFX0NIQVQQBBIhCh1VU0VSX1NPVVJDRV9GUklFTkRfSU5WSVRBVElPThAF",
            "EhUKEVVTRVJfU09VUkNFX1ZPSUNFEAYqdAoKQ2x1YlNvdXJjZRIVChFDTFVC",
            "X1NPVVJDRV9PVEhFUhAAEhcKE0NMVUJfU09VUkNFX01FU1NBR0UQARIZChVD",
            "TFVCX1NPVVJDRV9DTFVCX05BTUUQAhIbChdDTFVCX1NPVVJDRV9TVFJFQU1f",
            "TkFNRRADQgOAAQA="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Bgs.Protocol.Account.V1.AccountTypesReflection.Descriptor, global::Bgs.Protocol.RpcTypesReflection.Descriptor, global::Bgs.Protocol.MessageTypesReflection.Descriptor, global::Bgs.Protocol.MessageOptionsReflection.Descriptor, global::Bgs.Protocol.FieldOptionsReflection.Descriptor, global::Bgs.Protocol.MethodOptionsReflection.Descriptor, global::Bgs.Protocol.ServiceOptionsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Bgs.Protocol.Report.V2.IssueType), typeof(global::Bgs.Protocol.Report.V2.UserSource), typeof(global::Bgs.Protocol.Report.V2.ClubSource), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Bgs.Protocol.Report.V2.ReportItem), global::Bgs.Protocol.Report.V2.ReportItem.Parser, new[]{ "MessageId" }, new[]{ "Type" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Bgs.Protocol.Report.V2.UserOptions), global::Bgs.Protocol.Report.V2.UserOptions.Parser, new[]{ "TargetId", "Type", "Source", "Item" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Bgs.Protocol.Report.V2.ClubOptions), global::Bgs.Protocol.Report.V2.ClubOptions.Parser, new[]{ "ClubId", "StreamId", "Type", "Source", "Item" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum IssueType {
    [pbr::OriginalName("ISSUE_TYPE_SPAM")] Spam = 0,
    [pbr::OriginalName("ISSUE_TYPE_HARASSMENT")] Harassment = 1,
    [pbr::OriginalName("ISSUE_TYPE_OFFENSIVE_CONTENT")] OffensiveContent = 3,
    [pbr::OriginalName("ISSUE_TYPE_HACKING")] Hacking = 4,
    [pbr::OriginalName("ISSUE_TYPE_BOTTING")] Botting = 5,
  }

  public enum UserSource {
    [pbr::OriginalName("USER_SOURCE_OTHER")] Other = 0,
    [pbr::OriginalName("USER_SOURCE_WHISPER")] Whisper = 1,
    [pbr::OriginalName("USER_SOURCE_PROFILE")] Profile = 2,
    [pbr::OriginalName("USER_SOURCE_BATTLE_TAG")] BattleTag = 3,
    [pbr::OriginalName("USER_SOURCE_CHAT")] Chat = 4,
    [pbr::OriginalName("USER_SOURCE_FRIEND_INVITATION")] FriendInvitation = 5,
    [pbr::OriginalName("USER_SOURCE_VOICE")] Voice = 6,
  }

  public enum ClubSource {
    [pbr::OriginalName("CLUB_SOURCE_OTHER")] Other = 0,
    [pbr::OriginalName("CLUB_SOURCE_MESSAGE")] Message = 1,
    [pbr::OriginalName("CLUB_SOURCE_CLUB_NAME")] ClubName = 2,
    [pbr::OriginalName("CLUB_SOURCE_STREAM_NAME")] StreamName = 3,
  }

  #endregion

  #region Messages
  public sealed partial class ReportItem : pb::IMessage<ReportItem> {
    private static readonly pb::MessageParser<ReportItem> _parser = new pb::MessageParser<ReportItem>(() => new ReportItem());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ReportItem> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Bgs.Protocol.Report.V2.ReportTypesReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReportItem() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReportItem(ReportItem other) : this() {
      switch (other.TypeCase) {
        case TypeOneofCase.MessageId:
          MessageId = other.MessageId.Clone();
          break;
      }

      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReportItem Clone() {
      return new ReportItem(this);
    }

    /// <summary>Field number for the "message_id" field.</summary>
    public const int MessageIdFieldNumber = 1;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Bgs.Protocol.MessageId MessageId {
      get { return HasMessageId ? (global::Bgs.Protocol.MessageId) type_ : null; }
      set {
        type_ = value;
        typeCase_ = value == null ? TypeOneofCase.None : TypeOneofCase.MessageId;
      }
    }
    /// <summary>Gets whether the "message_id" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasMessageId {
      get { return typeCase_ == TypeOneofCase.MessageId; }
    }
    /// <summary> Clears the value of the oneof if it's currently set to "message_id" </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearMessageId() {
      if (HasMessageId) {
        ClearType();
      }
    }

    private object type_;
    /// <summary>Enum of possible cases for the "type" oneof.</summary>
    public enum TypeOneofCase {
      None = 0,
      MessageId = 1,
    }
    private TypeOneofCase typeCase_ = TypeOneofCase.None;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TypeOneofCase TypeCase {
      get { return typeCase_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearType() {
      typeCase_ = TypeOneofCase.None;
      type_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ReportItem);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ReportItem other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(MessageId, other.MessageId)) return false;
      if (TypeCase != other.TypeCase) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (HasMessageId) hash ^= MessageId.GetHashCode();
      hash ^= (int) typeCase_;
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
      if (HasMessageId) {
        output.WriteRawTag(10);
        output.WriteMessage(MessageId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (HasMessageId) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(MessageId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ReportItem other) {
      if (other == null) {
        return;
      }
      switch (other.TypeCase) {
        case TypeOneofCase.MessageId:
          if (MessageId == null) {
            MessageId = new global::Bgs.Protocol.MessageId();
          }
          MessageId.MergeFrom(other.MessageId);
          break;
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
            global::Bgs.Protocol.MessageId subBuilder = new global::Bgs.Protocol.MessageId();
            if (HasMessageId) {
              subBuilder.MergeFrom(MessageId);
            }
            input.ReadMessage(subBuilder);
            MessageId = subBuilder;
            break;
          }
        }
      }
    }

  }

  public sealed partial class UserOptions : pb::IMessage<UserOptions> {
    private static readonly pb::MessageParser<UserOptions> _parser = new pb::MessageParser<UserOptions>(() => new UserOptions());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UserOptions> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Bgs.Protocol.Report.V2.ReportTypesReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserOptions() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserOptions(UserOptions other) : this() {
      _hasBits0 = other._hasBits0;
      targetId_ = other.HasTargetId ? other.targetId_.Clone() : null;
      type_ = other.type_;
      source_ = other.source_;
      item_ = other.HasItem ? other.item_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserOptions Clone() {
      return new UserOptions(this);
    }

    /// <summary>Field number for the "target_id" field.</summary>
    public const int TargetIdFieldNumber = 1;
    private global::Bgs.Protocol.Account.V1.AccountId targetId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Bgs.Protocol.Account.V1.AccountId TargetId {
      get { return targetId_; }
      set {
        targetId_ = value;
      }
    }
    /// <summary>Gets whether the target_id field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasTargetId {
      get { return targetId_ != null; }
    }
    /// <summary>Clears the value of the target_id field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearTargetId() {
      targetId_ = null;
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 2;
    private readonly static global::Bgs.Protocol.Report.V2.IssueType TypeDefaultValue = global::Bgs.Protocol.Report.V2.IssueType.Spam;

    private global::Bgs.Protocol.Report.V2.IssueType type_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Bgs.Protocol.Report.V2.IssueType Type {
      get { if ((_hasBits0 & 1) != 0) { return type_; } else { return TypeDefaultValue; } }
      set {
        _hasBits0 |= 1;
        type_ = value;
      }
    }
    /// <summary>Gets whether the "type" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasType {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "type" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearType() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "source" field.</summary>
    public const int SourceFieldNumber = 3;
    private readonly static global::Bgs.Protocol.Report.V2.UserSource SourceDefaultValue = global::Bgs.Protocol.Report.V2.UserSource.Other;

    private global::Bgs.Protocol.Report.V2.UserSource source_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Bgs.Protocol.Report.V2.UserSource Source {
      get { if ((_hasBits0 & 2) != 0) { return source_; } else { return SourceDefaultValue; } }
      set {
        _hasBits0 |= 2;
        source_ = value;
      }
    }
    /// <summary>Gets whether the "source" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasSource {
      get { return (_hasBits0 & 2) != 0; }
    }
    /// <summary>Clears the value of the "source" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearSource() {
      _hasBits0 &= ~2;
    }

    /// <summary>Field number for the "item" field.</summary>
    public const int ItemFieldNumber = 4;
    private global::Bgs.Protocol.Report.V2.ReportItem item_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Bgs.Protocol.Report.V2.ReportItem Item {
      get { return item_; }
      set {
        item_ = value;
      }
    }
    /// <summary>Gets whether the item field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasItem {
      get { return item_ != null; }
    }
    /// <summary>Clears the value of the item field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearItem() {
      item_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UserOptions);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UserOptions other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(TargetId, other.TargetId)) return false;
      if (Type != other.Type) return false;
      if (Source != other.Source) return false;
      if (!object.Equals(Item, other.Item)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (HasTargetId) hash ^= TargetId.GetHashCode();
      if (HasType) hash ^= Type.GetHashCode();
      if (HasSource) hash ^= Source.GetHashCode();
      if (HasItem) hash ^= Item.GetHashCode();
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
      if (HasTargetId) {
        output.WriteRawTag(10);
        output.WriteMessage(TargetId);
      }
      if (HasType) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Type);
      }
      if (HasSource) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Source);
      }
      if (HasItem) {
        output.WriteRawTag(34);
        output.WriteMessage(Item);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (HasTargetId) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TargetId);
      }
      if (HasType) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (HasSource) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Source);
      }
      if (HasItem) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Item);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UserOptions other) {
      if (other == null) {
        return;
      }
      if (other.HasTargetId) {
        if (!HasTargetId) {
          TargetId = new global::Bgs.Protocol.Account.V1.AccountId();
        }
        TargetId.MergeFrom(other.TargetId);
      }
      if (other.HasType) {
        Type = other.Type;
      }
      if (other.HasSource) {
        Source = other.Source;
      }
      if (other.HasItem) {
        if (!HasItem) {
          Item = new global::Bgs.Protocol.Report.V2.ReportItem();
        }
        Item.MergeFrom(other.Item);
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
            if (!HasTargetId) {
              TargetId = new global::Bgs.Protocol.Account.V1.AccountId();
            }
            input.ReadMessage(TargetId);
            break;
          }
          case 16: {
            Type = (global::Bgs.Protocol.Report.V2.IssueType) input.ReadEnum();
            break;
          }
          case 24: {
            Source = (global::Bgs.Protocol.Report.V2.UserSource) input.ReadEnum();
            break;
          }
          case 34: {
            if (!HasItem) {
              Item = new global::Bgs.Protocol.Report.V2.ReportItem();
            }
            input.ReadMessage(Item);
            break;
          }
        }
      }
    }

  }

  public sealed partial class ClubOptions : pb::IMessage<ClubOptions> {
    private static readonly pb::MessageParser<ClubOptions> _parser = new pb::MessageParser<ClubOptions>(() => new ClubOptions());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ClubOptions> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Bgs.Protocol.Report.V2.ReportTypesReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClubOptions() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClubOptions(ClubOptions other) : this() {
      _hasBits0 = other._hasBits0;
      clubId_ = other.clubId_;
      streamId_ = other.streamId_;
      type_ = other.type_;
      source_ = other.source_;
      item_ = other.HasItem ? other.item_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ClubOptions Clone() {
      return new ClubOptions(this);
    }

    /// <summary>Field number for the "club_id" field.</summary>
    public const int ClubIdFieldNumber = 1;
    private readonly static ulong ClubIdDefaultValue = 0UL;

    private ulong clubId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong ClubId {
      get { if ((_hasBits0 & 1) != 0) { return clubId_; } else { return ClubIdDefaultValue; } }
      set {
        _hasBits0 |= 1;
        clubId_ = value;
      }
    }
    /// <summary>Gets whether the "club_id" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasClubId {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "club_id" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearClubId() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "stream_id" field.</summary>
    public const int StreamIdFieldNumber = 2;
    private readonly static ulong StreamIdDefaultValue = 0UL;

    private ulong streamId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong StreamId {
      get { if ((_hasBits0 & 2) != 0) { return streamId_; } else { return StreamIdDefaultValue; } }
      set {
        _hasBits0 |= 2;
        streamId_ = value;
      }
    }
    /// <summary>Gets whether the "stream_id" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasStreamId {
      get { return (_hasBits0 & 2) != 0; }
    }
    /// <summary>Clears the value of the "stream_id" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearStreamId() {
      _hasBits0 &= ~2;
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 3;
    private readonly static global::Bgs.Protocol.Report.V2.IssueType TypeDefaultValue = global::Bgs.Protocol.Report.V2.IssueType.Spam;

    private global::Bgs.Protocol.Report.V2.IssueType type_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Bgs.Protocol.Report.V2.IssueType Type {
      get { if ((_hasBits0 & 4) != 0) { return type_; } else { return TypeDefaultValue; } }
      set {
        _hasBits0 |= 4;
        type_ = value;
      }
    }
    /// <summary>Gets whether the "type" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasType {
      get { return (_hasBits0 & 4) != 0; }
    }
    /// <summary>Clears the value of the "type" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearType() {
      _hasBits0 &= ~4;
    }

    /// <summary>Field number for the "source" field.</summary>
    public const int SourceFieldNumber = 4;
    private readonly static global::Bgs.Protocol.Report.V2.ClubSource SourceDefaultValue = global::Bgs.Protocol.Report.V2.ClubSource.Other;

    private global::Bgs.Protocol.Report.V2.ClubSource source_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Bgs.Protocol.Report.V2.ClubSource Source {
      get { if ((_hasBits0 & 8) != 0) { return source_; } else { return SourceDefaultValue; } }
      set {
        _hasBits0 |= 8;
        source_ = value;
      }
    }
    /// <summary>Gets whether the "source" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasSource {
      get { return (_hasBits0 & 8) != 0; }
    }
    /// <summary>Clears the value of the "source" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearSource() {
      _hasBits0 &= ~8;
    }

    /// <summary>Field number for the "item" field.</summary>
    public const int ItemFieldNumber = 5;
    private global::Bgs.Protocol.Report.V2.ReportItem item_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Bgs.Protocol.Report.V2.ReportItem Item {
      get { return item_; }
      set {
        item_ = value;
      }
    }
    /// <summary>Gets whether the item field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool HasItem {
      get { return item_ != null; }
    }
    /// <summary>Clears the value of the item field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void ClearItem() {
      item_ = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ClubOptions);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ClubOptions other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ClubId != other.ClubId) return false;
      if (StreamId != other.StreamId) return false;
      if (Type != other.Type) return false;
      if (Source != other.Source) return false;
      if (!object.Equals(Item, other.Item)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (HasClubId) hash ^= ClubId.GetHashCode();
      if (HasStreamId) hash ^= StreamId.GetHashCode();
      if (HasType) hash ^= Type.GetHashCode();
      if (HasSource) hash ^= Source.GetHashCode();
      if (HasItem) hash ^= Item.GetHashCode();
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
      if (HasClubId) {
        output.WriteRawTag(8);
        output.WriteUInt64(ClubId);
      }
      if (HasStreamId) {
        output.WriteRawTag(16);
        output.WriteUInt64(StreamId);
      }
      if (HasType) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Type);
      }
      if (HasSource) {
        output.WriteRawTag(32);
        output.WriteEnum((int) Source);
      }
      if (HasItem) {
        output.WriteRawTag(42);
        output.WriteMessage(Item);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (HasClubId) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(ClubId);
      }
      if (HasStreamId) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(StreamId);
      }
      if (HasType) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (HasSource) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Source);
      }
      if (HasItem) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Item);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ClubOptions other) {
      if (other == null) {
        return;
      }
      if (other.HasClubId) {
        ClubId = other.ClubId;
      }
      if (other.HasStreamId) {
        StreamId = other.StreamId;
      }
      if (other.HasType) {
        Type = other.Type;
      }
      if (other.HasSource) {
        Source = other.Source;
      }
      if (other.HasItem) {
        if (!HasItem) {
          Item = new global::Bgs.Protocol.Report.V2.ReportItem();
        }
        Item.MergeFrom(other.Item);
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
            ClubId = input.ReadUInt64();
            break;
          }
          case 16: {
            StreamId = input.ReadUInt64();
            break;
          }
          case 24: {
            Type = (global::Bgs.Protocol.Report.V2.IssueType) input.ReadEnum();
            break;
          }
          case 32: {
            Source = (global::Bgs.Protocol.Report.V2.ClubSource) input.ReadEnum();
            break;
          }
          case 42: {
            if (!HasItem) {
              Item = new global::Bgs.Protocol.Report.V2.ReportItem();
            }
            input.ReadMessage(Item);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code