// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using HexaGen.Runtime;
using System.Numerics;

namespace Hexa.NET.ImGuiNodeEditor
{
	public static unsafe partial class Extensions
	{
		public static void BeginNode(this NodeId id)
		{
			ImGuiNodeEditor.BeginNodeNative(id);
		}

		public static bool BeginGroupHint(this NodeId nodeId)
		{
			byte ret = ImGuiNodeEditor.BeginGroupHintNative(nodeId);
			return ret != 0;
		}

		/// <summary>
		/// TODO: Add a way to manage node background channels<br/>
		/// </summary>
		public static ImDrawList* GetNodeBackgroundDrawList(this NodeId nodeId)
		{
			ImDrawList* ret = ImGuiNodeEditor.GetNodeBackgroundDrawListNative(nodeId);
			return ret;
		}

		public static void SetNodePosition(this NodeId nodeId, Vector2* editorPosition)
		{
			ImGuiNodeEditor.SetNodePositionNative(nodeId, editorPosition);
		}

		public static void SetNodePosition(this NodeId nodeId, ref Vector2 editorPosition)
		{
			fixed (Vector2* peditorPosition = &editorPosition)
			{
				ImGuiNodeEditor.SetNodePositionNative(nodeId, (Vector2*)peditorPosition);
			}
		}

		public static void SetGroupSize(this NodeId nodeId, Vector2* size)
		{
			ImGuiNodeEditor.SetGroupSizeNative(nodeId, size);
		}

		public static void SetGroupSize(this NodeId nodeId, ref Vector2 size)
		{
			fixed (Vector2* psize = &size)
			{
				ImGuiNodeEditor.SetGroupSizeNative(nodeId, (Vector2*)psize);
			}
		}

		public static Vector2 GetNodePosition(this NodeId nodeId)
		{
			Vector2 ret = ImGuiNodeEditor.GetNodePositionNative(nodeId);
			return ret;
		}

		public static Vector2 GetNodeSize(this NodeId nodeId)
		{
			Vector2 ret = ImGuiNodeEditor.GetNodeSizeNative(nodeId);
			return ret;
		}

		public static void CenterNodeOnScreen(this NodeId nodeId)
		{
			ImGuiNodeEditor.CenterNodeOnScreenNative(nodeId);
		}

		public static void SetNodeZPosition(this NodeId nodeId, float z)
		{
			ImGuiNodeEditor.SetNodeZPositionNative(nodeId, z);
		}

		public static float GetNodeZPosition(this NodeId nodeId)
		{
			float ret = ImGuiNodeEditor.GetNodeZPositionNative(nodeId);
			return ret;
		}

		public static void RestoreNodeState(this NodeId nodeId)
		{
			ImGuiNodeEditor.RestoreNodeStateNative(nodeId);
		}

		public static bool IsNodeSelected(this NodeId nodeId)
		{
			byte ret = ImGuiNodeEditor.IsNodeSelectedNative(nodeId);
			return ret != 0;
		}

		public static void SelectNode(this NodeId nodeId, bool append)
		{
			ImGuiNodeEditor.SelectNodeNative(nodeId, append ? (byte)1 : (byte)0);
		}

		public static void DeselectNode(this NodeId nodeId)
		{
			ImGuiNodeEditor.DeselectNodeNative(nodeId);
		}

		public static bool DeleteNode(this NodeId nodeId)
		{
			byte ret = ImGuiNodeEditor.DeleteNodeNative(nodeId);
			return ret != 0;
		}

		/// <summary>
		/// </summary>
		public static bool HasAnyLinks(this NodeId nodeId)
		{
			byte ret = ImGuiNodeEditor.HasAnyLinksNative(nodeId);
			return ret != 0;
		}

		/// <summary>
		/// </summary>
		public static int BreakLinks(this NodeId nodeId)
		{
			int ret = ImGuiNodeEditor.BreakLinksNative(nodeId);
			return ret;
		}

		public static bool Link(this LinkId id, PinId startPinId, PinId endPinId, Vector4* color, float thickness)
		{
			byte ret = ImGuiNodeEditor.LinkNative(id, startPinId, endPinId, color, thickness);
			return ret != 0;
		}

		public static bool Link(this LinkId id, PinId startPinId, PinId endPinId, ref Vector4 color, float thickness)
		{
			fixed (Vector4* pcolor = &color)
			{
				byte ret = ImGuiNodeEditor.LinkNative(id, startPinId, endPinId, (Vector4*)pcolor, thickness);
				return ret != 0;
			}
		}

		public static void Flow(this LinkId linkId, FlowDirection direction)
		{
			ImGuiNodeEditor.FlowNative(linkId, direction);
		}

		public static bool IsLinkSelected(this LinkId linkId)
		{
			byte ret = ImGuiNodeEditor.IsLinkSelectedNative(linkId);
			return ret != 0;
		}

		public static void SelectLink(this LinkId linkId, bool append)
		{
			ImGuiNodeEditor.SelectLinkNative(linkId, append ? (byte)1 : (byte)0);
		}

		public static void DeselectLink(this LinkId linkId)
		{
			ImGuiNodeEditor.DeselectLinkNative(linkId);
		}

		public static bool DeleteLink(this LinkId linkId)
		{
			byte ret = ImGuiNodeEditor.DeleteLinkNative(linkId);
			return ret != 0;
		}

		public static bool GetLinkPins(this LinkId linkId, PinId* startPinId, PinId* endPinId)
		{
			byte ret = ImGuiNodeEditor.GetLinkPinsNative(linkId, startPinId, endPinId);
			return ret != 0;
		}

		public static bool GetLinkPins(this LinkId linkId, ref PinId startPinId, PinId* endPinId)
		{
			fixed (PinId* pstartPinId = &startPinId)
			{
				byte ret = ImGuiNodeEditor.GetLinkPinsNative(linkId, (PinId*)pstartPinId, endPinId);
				return ret != 0;
			}
		}

		public static bool GetLinkPins(this LinkId linkId, PinId* startPinId, ref PinId endPinId)
		{
			fixed (PinId* pendPinId = &endPinId)
			{
				byte ret = ImGuiNodeEditor.GetLinkPinsNative(linkId, startPinId, (PinId*)pendPinId);
				return ret != 0;
			}
		}

		public static bool GetLinkPins(this LinkId linkId, ref PinId startPinId, ref PinId endPinId)
		{
			fixed (PinId* pstartPinId = &startPinId)
			{
				fixed (PinId* pendPinId = &endPinId)
				{
					byte ret = ImGuiNodeEditor.GetLinkPinsNative(linkId, (PinId*)pstartPinId, (PinId*)pendPinId);
					return ret != 0;
				}
			}
		}

		public static void BeginPin(this PinId id, PinKind kind)
		{
			ImGuiNodeEditor.BeginPinNative(id, kind);
		}

		/// <summary>
		/// </summary>
		public static bool HasAnyLinks(this PinId pinId)
		{
			byte ret = ImGuiNodeEditor.HasAnyLinksNative(pinId);
			return ret != 0;
		}

		/// <summary>
		/// </summary>
		public static int BreakLinks(this PinId pinId)
		{
			int ret = ImGuiNodeEditor.BreakLinksNative(pinId);
			return ret;
		}

		public static bool HadAnyLinks(this PinId pinId)
		{
			byte ret = ImGuiNodeEditor.PinHadAnyLinksNative(pinId);
			return ret != 0;
		}

	}
}
