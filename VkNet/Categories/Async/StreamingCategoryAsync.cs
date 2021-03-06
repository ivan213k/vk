using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using VkNet.Enums.SafetyEnums;
using VkNet.Model;
using VkNet.Utils;

namespace VkNet.Categories
{
	/// <inheritdoc />
	public partial class StreamingCategory
	{
		/// <inheritdoc />
		public Task<StreamingServerUrl> GetServerUrlAsync()
		{
			return TypeHelper.TryInvokeMethodAsync(func: () => _vk.Streaming.GetServerUrl());
		}

		/// <inheritdoc />
		public Task<StreamingSettings> GetSettingsAsync()
		{
			return TypeHelper.TryInvokeMethodAsync(func: () => _vk.Streaming.GetSettings());
		}

		/// <inheritdoc />
		public Task<ReadOnlyCollection<StreamingStats>> GetStatsAsync(string type
																			, string interval
																			, DateTime? startTime = null
																			, DateTime? endTime = null)
		{
			return TypeHelper.TryInvokeMethodAsync(func: () =>
					_vk.Streaming.GetStats(type: type, interval: interval, startTime: startTime, endTime: endTime));
		}

		/// <inheritdoc />
		public Task<bool> SetSettingsAsync(MonthlyLimit monthlyTier)
		{
			return TypeHelper.TryInvokeMethodAsync(func: () => _vk.Streaming.SetSettings(monthlyTier: monthlyTier));
		}
	}
}