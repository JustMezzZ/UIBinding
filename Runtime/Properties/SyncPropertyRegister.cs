using UnityEngine;

namespace UIBinding
{
    public class SyncPropertyRegister : ISyncRegister
    {
        public void Register()
        {
            // None�Ƚ����⣬����ע��
            PropertyFactory.Register<SyncNone>(nameof(PR.None));

            // ����ע����������
            var prFields = typeof(PR).GetFields();
            for (int i = 0; i < prFields.Length; i++)
            {
                var field = prFields[i];
                if (!field.HasAttribute<PRBindAttribute>())
                    continue;

                PropertyFactory.Register(field.Name, System.Type.GetType($"UIBinding.Sync{field.Name}"));
            }
        }
    }
}
