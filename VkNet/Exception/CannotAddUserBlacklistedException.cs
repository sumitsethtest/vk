﻿using System;
using VkNet.Model;
using VkNet.Utils;

namespace VkNet.Exception
{
	/// <summary>
	/// Исключение, которые выбрасывается при попытке добавить в друзья пользователя,
	/// который занесен в Ваш черный список.
	/// Код ошибки - 176
	/// </summary>
	[Serializable]
	public sealed class CannotAddUserBlacklistedException : VkApiMethodInvokeException
	{
		/// <inheritdoc />
		public CannotAddUserBlacklistedException(VkError response) : base(response)
		{
		}

		/// <inheritdoc />
		internal override int ErrorCode => VkErrorCode.CannotAddUserBlacklisted;
	}
}