using System;
using System.Collections.Generic;
using UnityEngine;

namespace UIBinding
{
    /// <summary>
    /// һ�� BindingItem ��Ӧһ�� ViewModel ������
    /// </summary>
    [Serializable]
    public class BindingItem
    {
        public string vmPropertyName;
        public List<GameObject> uiObjects;
        public List<Component> uiComponents;
        public List<string> uiProperties;
        public List<ISyncProperty> syncProperties;
    }

    /// <summary>
    /// ���ݰ�����
    /// </summary>
    public class BindingConfig : MonoBehaviour
    {
        /// <summary>
        /// ViewModel �ļ��� guid
        /// </summary>
        [SerializeField]
        private string vmKlassGuid;
        /// <summary>
        /// �󶨵� ViewModel �ļ�
        /// </summary>
        public string vmKlassName;
        /// <summary>
        /// �󶨵���������
        /// </summary>
        public List<BindingItem> itemList;
    }
}
