using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace Manager
{
    /// <summary>
    /// Class for Folder.
    /// </summary>
    [DataContract]
    public class Folder
    {
        /// <summary>
        /// Parent of the folder.
        /// </summary>
        [IgnoreDataMember]
        public Folder Parent;
        /// <summary>
        /// Level in the tree.
        /// </summary>
        [IgnoreDataMember]
        public int Level;
        /// <summary>
        /// Name of the folder.
        /// </summary>
        [DataMember]
        public string Name { set; get; }
        /// <summary>
        /// Products in the folder.
        /// </summary>
        [DataMember]
        public ObservableCollection<Product> Products { set; get; }
        /// <summary>
        /// Folders int the folder.
        /// </summary>
        [DataMember]
        public ObservableCollection<Folder> Folders { set; get; }
        // Flag 0 - non-empty, 1 - empty, 2 - system folder
        [DataMember]
        public int isEmpty = 1;
        /// <summary>
        /// Empty constructor.
        /// </summary>
        public Folder()
        {
            Products = new ObservableCollection<Product>();
            Folders = new ObservableCollection<Folder>();
        }

    }
}
