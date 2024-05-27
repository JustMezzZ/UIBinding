using UIBinding;
using UnityEngine;

namespace BasicUsage
{
    public class GameLauncher : MonoBehaviour
    {
        void Awake()
        {
            // ��ʼ����
            BindingInitializer.Initialize(new CustomSyncRegister());

            // �򿪲��Դ���
            UIManager.OpenView<TestView>("UI/Test/TestView");
        }
    }
}

