// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.Win32.SafeHandles;
using System;

namespace Microsoft.Win32
{
#if REGISTRY_ASSEMBLY
    public
#else
    internal
#endif
    sealed partial class RegistryKey : MarshalByRefObject, IDisposable
    {
        private void ClosePerfDataKey()
        {
            // TODO: Implement this
            throw new PlatformNotSupportedException();
        }

        private void FlushCore()
        {
            // TODO: Implement this
            throw new PlatformNotSupportedException();
        }

        private RegistryKey CreateSubKeyInternalCore(string subkey, RegistryKeyPermissionCheck permissionCheck, object registrySecurityObj, RegistryOptions registryOptions)
        {
            // TODO: Implement this
            throw new PlatformNotSupportedException();
        }

        private void DeleteSubKeyCore(string subkey, bool throwOnMissingSubKey)
        {
            // TODO: Implement this
            throw new PlatformNotSupportedException();
        }

        private void DeleteSubKeyTreeCore(string subkey)
        {
            // TODO: Implement this
            throw new PlatformNotSupportedException();
        }

        private void DeleteValueCore(string name, bool throwOnMissingValue)
        {
            // TODO: Implement this
            throw new PlatformNotSupportedException();
        }

        private static RegistryKey OpenBaseKeyCore(RegistryHive hKey, RegistryView view)
        {
            // TODO: Implement this
            throw new PlatformNotSupportedException();
        }

        private static RegistryKey OpenRemoteBaseKeyCore(RegistryHive hKey, string machineName, RegistryView view)
        {
            throw new PlatformNotSupportedException(SR.Security_RegistryPermission); // remote stores not supported on Unix
        }

        private RegistryKey InternalOpenSubKeyCore(string name, RegistryKeyPermissionCheck permissionCheck, int rights, bool throwOnPermissionFailure)
        {
            // TODO: Implement this
            throw new PlatformNotSupportedException();
        }

        private RegistryKey InternalOpenSubKeyCore(string name, bool writable, bool throwOnPermissionFailure)
        {
            // TODO: Implement this
            throw new PlatformNotSupportedException();
        }

        internal RegistryKey InternalOpenSubKeyWithoutSecurityChecksCore(string name, bool writable)
        {
            // TODO: Implement this
            throw new PlatformNotSupportedException();
        }

        private SafeRegistryHandle SystemKeyHandle
        {
            get
            {
                // TODO: Implement this
                throw new PlatformNotSupportedException();
            }
        }

        private int InternalSubKeyCountCore()
        {
            // TODO: Implement this
            throw new PlatformNotSupportedException();
        }

        private string[] InternalGetSubKeyNamesCore(int subkeys)
        {
            // TODO: Implement this
            throw new PlatformNotSupportedException();
        }

        private int InternalValueCountCore()
        {
            // TODO: Implement this
            throw new PlatformNotSupportedException();
        }

        private string[] GetValueNamesCore(int values)
        {
            // TODO: Implement this
            throw new PlatformNotSupportedException();
        }

        private Object InternalGetValueCore(string name, Object defaultValue, bool doNotExpand)
        {
            // TODO: Implement this
            throw new PlatformNotSupportedException();
        }

        private RegistryValueKind GetValueKindCore(string name)
        {
            // TODO: Implement this
            throw new PlatformNotSupportedException();
        }

        private void SetValueCore(string name, Object value, RegistryValueKind valueKind)
        {
            // TODO: Implement this
            throw new PlatformNotSupportedException();
        }

        private bool ContainsRegistryValueCore(string name)
        {
            // TODO: Implement this
            throw new PlatformNotSupportedException();
        }

        private static bool IsWritable(int rights)
        {
            // TODO: Implement this
            throw new PlatformNotSupportedException();
        }

        private static int GetRegistryKeyAccess(bool isWritable)
        {
            // TODO: Implement this
            throw new PlatformNotSupportedException();
        }

        private static int GetRegistryKeyAccess(RegistryKeyPermissionCheck mode)
        {
            // TODO: Implement this
            throw new PlatformNotSupportedException();
        }
    }
}
