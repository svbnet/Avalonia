﻿namespace Avalonia.Automation.Provider
{
    /// <summary>
    /// Exposes methods and properties to support UI Automation client access to controls that
    /// initiate or perform a single, unambiguous action and do not maintain state when
    /// activated.
    /// </summary>
    public interface IInvokeProvider
    {
        /// <summary>
        /// Sends a request to activate a control and initiate its single, unambiguous action.
        /// </summary>
        /// <remarks>
        /// <list type="table">
        ///   <item>
        ///     <term>Windows</term>
        ///     <description><c>IInvokeProvider.Invoke</c></description>
        ///   </item>
        ///   <item>
        ///     <term>macOS</term>
        ///     <description><c>NSAccessibilityProtocol.accessibilityPerformPress</c></description>
        ///   </item>
        /// </list>
        /// </remarks>
        void Invoke();
    }
}
