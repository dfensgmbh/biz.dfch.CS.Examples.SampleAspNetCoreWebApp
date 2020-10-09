﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generation date: 09/10/2020 15:11:59
namespace biz.dfch.CS.Examples.SampleAspNetCoreWebApi.Models
{
    /// <summary>
    /// There are no comments for AlbumSingle in the schema.
    /// </summary>
    public partial class AlbumSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<Album>
    {
        /// <summary>
        /// Initialize a new AlbumSingle object.
        /// </summary>
        public AlbumSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new AlbumSingle object.
        /// </summary>
        public AlbumSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new AlbumSingle object.
        /// </summary>
        public AlbumSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<Album> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Songs in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::biz.dfch.CS.Examples.SampleAspNetCoreWebApi.Models.Song> Songs
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Songs == null))
                {
                    this._Songs = Context.CreateQuery<global::biz.dfch.CS.Examples.SampleAspNetCoreWebApi.Models.Song>(GetPath("Songs"));
                }
                return this._Songs;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::biz.dfch.CS.Examples.SampleAspNetCoreWebApi.Models.Song> _Songs;
    }
    /// <summary>
    /// There are no comments for Album in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Id")]
    public partial class Album : global::Microsoft.OData.Client.BaseEntityType
    {
        /// <summary>
        /// Create a new Album object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static Album CreateAlbum(int ID)
        {
            Album album = new Album();
            album.Id = ID;
            return album;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property Songs in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::System.Collections.ObjectModel.Collection<global::biz.dfch.CS.Examples.SampleAspNetCoreWebApi.Models.Song> Songs
        {
            get
            {
                return this._Songs;
            }
            set
            {
                this.OnSongsChanging(value);
                this._Songs = value;
                this.OnSongsChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::System.Collections.ObjectModel.Collection<global::biz.dfch.CS.Examples.SampleAspNetCoreWebApi.Models.Song> _Songs = new global::System.Collections.ObjectModel.Collection<global::biz.dfch.CS.Examples.SampleAspNetCoreWebApi.Models.Song>();
        partial void OnSongsChanging(global::System.Collections.ObjectModel.Collection<global::biz.dfch.CS.Examples.SampleAspNetCoreWebApi.Models.Song> value);
        partial void OnSongsChanged();
    }
    /// <summary>
    /// There are no comments for SongSingle in the schema.
    /// </summary>
    public partial class SongSingle : global::Microsoft.OData.Client.DataServiceQuerySingle<Song>
    {
        /// <summary>
        /// Initialize a new SongSingle object.
        /// </summary>
        public SongSingle(global::Microsoft.OData.Client.DataServiceContext context, string path)
            : base(context, path) {}

        /// <summary>
        /// Initialize a new SongSingle object.
        /// </summary>
        public SongSingle(global::Microsoft.OData.Client.DataServiceContext context, string path, bool isComposable)
            : base(context, path, isComposable) {}

        /// <summary>
        /// Initialize a new SongSingle object.
        /// </summary>
        public SongSingle(global::Microsoft.OData.Client.DataServiceQuerySingle<Song> query)
            : base(query) {}

        /// <summary>
        /// There are no comments for Album in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::biz.dfch.CS.Examples.SampleAspNetCoreWebApi.Models.AlbumSingle Album
        {
            get
            {
                if (!this.IsComposable)
                {
                    throw new global::System.NotSupportedException("The previous function is not composable.");
                }
                if ((this._Album == null))
                {
                    this._Album = new global::biz.dfch.CS.Examples.SampleAspNetCoreWebApi.Models.AlbumSingle(this.Context, GetPath("Album"));
                }
                return this._Album;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::biz.dfch.CS.Examples.SampleAspNetCoreWebApi.Models.AlbumSingle _Album;
    }
    /// <summary>
    /// There are no comments for Song in the schema.
    /// </summary>
    /// <KeyProperties>
    /// Id
    /// </KeyProperties>
    [global::Microsoft.OData.Client.Key("Id")]
    public partial class Song : global::Microsoft.OData.Client.BaseEntityType
    {
        /// <summary>
        /// Create a new Song object.
        /// </summary>
        /// <param name="ID">Initial value of Id.</param>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public static Song CreateSong(int ID)
        {
            Song song = new Song();
            song.Id = ID;
            return song;
        }
        /// <summary>
        /// There are no comments for Property Id in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual int Id
        {
            get
            {
                return this._Id;
            }
            set
            {
                this.OnIdChanging(value);
                this._Id = value;
                this.OnIdChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private int _Id;
        partial void OnIdChanging(int value);
        partial void OnIdChanged();
        /// <summary>
        /// There are no comments for Property Name in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual string Name
        {
            get
            {
                return this._Name;
            }
            set
            {
                this.OnNameChanging(value);
                this._Name = value;
                this.OnNameChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private string _Name;
        partial void OnNameChanging(string value);
        partial void OnNameChanged();
        /// <summary>
        /// There are no comments for Property Album in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::biz.dfch.CS.Examples.SampleAspNetCoreWebApi.Models.Album Album
        {
            get
            {
                return this._Album;
            }
            set
            {
                this.OnAlbumChanging(value);
                this._Album = value;
                this.OnAlbumChanged();
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::biz.dfch.CS.Examples.SampleAspNetCoreWebApi.Models.Album _Album;
        partial void OnAlbumChanging(global::biz.dfch.CS.Examples.SampleAspNetCoreWebApi.Models.Album value);
        partial void OnAlbumChanged();
    }
    /// <summary>
    /// Class containing all extension methods
    /// </summary>
    public static class ExtensionMethods
    {
        /// <summary>
        /// Get an entity of type global::biz.dfch.CS.Examples.SampleAspNetCoreWebApi.Models.Album as global::biz.dfch.CS.Examples.SampleAspNetCoreWebApi.Models.AlbumSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::biz.dfch.CS.Examples.SampleAspNetCoreWebApi.Models.AlbumSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::biz.dfch.CS.Examples.SampleAspNetCoreWebApi.Models.Album> source, global::System.Collections.Generic.IDictionary<string, object> keys)
        {
            return new global::biz.dfch.CS.Examples.SampleAspNetCoreWebApi.Models.AlbumSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::biz.dfch.CS.Examples.SampleAspNetCoreWebApi.Models.Album as global::biz.dfch.CS.Examples.SampleAspNetCoreWebApi.Models.AlbumSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="id">The value of id</param>
        public static global::biz.dfch.CS.Examples.SampleAspNetCoreWebApi.Models.AlbumSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::biz.dfch.CS.Examples.SampleAspNetCoreWebApi.Models.Album> source,
            int id)
        {
            global::System.Collections.Generic.IDictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "Id", id }
            };
            return new global::biz.dfch.CS.Examples.SampleAspNetCoreWebApi.Models.AlbumSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::biz.dfch.CS.Examples.SampleAspNetCoreWebApi.Models.Song as global::biz.dfch.CS.Examples.SampleAspNetCoreWebApi.Models.SongSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="keys">dictionary with the names and values of keys</param>
        public static global::biz.dfch.CS.Examples.SampleAspNetCoreWebApi.Models.SongSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::biz.dfch.CS.Examples.SampleAspNetCoreWebApi.Models.Song> source, global::System.Collections.Generic.IDictionary<string, object> keys)
        {
            return new global::biz.dfch.CS.Examples.SampleAspNetCoreWebApi.Models.SongSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
        /// <summary>
        /// Get an entity of type global::biz.dfch.CS.Examples.SampleAspNetCoreWebApi.Models.Song as global::biz.dfch.CS.Examples.SampleAspNetCoreWebApi.Models.SongSingle specified by key from an entity set
        /// </summary>
        /// <param name="source">source entity set</param>
        /// <param name="id">The value of id</param>
        public static global::biz.dfch.CS.Examples.SampleAspNetCoreWebApi.Models.SongSingle ByKey(this global::Microsoft.OData.Client.DataServiceQuery<global::biz.dfch.CS.Examples.SampleAspNetCoreWebApi.Models.Song> source,
            int id)
        {
            global::System.Collections.Generic.IDictionary<string, object> keys = new global::System.Collections.Generic.Dictionary<string, object>
            {
                { "Id", id }
            };
            return new global::biz.dfch.CS.Examples.SampleAspNetCoreWebApi.Models.SongSingle(source.Context, source.GetKeyPath(global::Microsoft.OData.Client.Serializer.GetKeyString(source.Context, keys)));
        }
    }
}
namespace Default
{
    /// <summary>
    /// There are no comments for Container in the schema.
    /// </summary>
    public partial class Container : global::Microsoft.OData.Client.DataServiceContext
    {
        /// <summary>
        /// Initialize a new Container object.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public Container(global::System.Uri serviceRoot) :
                base(serviceRoot, global::Microsoft.OData.Client.ODataProtocolVersion.V4)
        {
            this.OnContextCreated();
            this.Format.LoadServiceModel = GeneratedEdmModel.GetInstance;
            this.Format.UseJson();
        }
        partial void OnContextCreated();
        /// <summary>
        /// There are no comments for Albums in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::biz.dfch.CS.Examples.SampleAspNetCoreWebApi.Models.Album> Albums
        {
            get
            {
                if ((this._Albums == null))
                {
                    this._Albums = base.CreateQuery<global::biz.dfch.CS.Examples.SampleAspNetCoreWebApi.Models.Album>("Albums");
                }
                return this._Albums;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::biz.dfch.CS.Examples.SampleAspNetCoreWebApi.Models.Album> _Albums;
        /// <summary>
        /// There are no comments for Songs in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual global::Microsoft.OData.Client.DataServiceQuery<global::biz.dfch.CS.Examples.SampleAspNetCoreWebApi.Models.Song> Songs
        {
            get
            {
                if ((this._Songs == null))
                {
                    this._Songs = base.CreateQuery<global::biz.dfch.CS.Examples.SampleAspNetCoreWebApi.Models.Song>("Songs");
                }
                return this._Songs;
            }
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private global::Microsoft.OData.Client.DataServiceQuery<global::biz.dfch.CS.Examples.SampleAspNetCoreWebApi.Models.Song> _Songs;
        /// <summary>
        /// There are no comments for Albums in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual void AddToAlbums(global::biz.dfch.CS.Examples.SampleAspNetCoreWebApi.Models.Album album)
        {
            base.AddObject("Albums", album);
        }
        /// <summary>
        /// There are no comments for Songs in the schema.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        public virtual void AddToSongs(global::biz.dfch.CS.Examples.SampleAspNetCoreWebApi.Models.Song song)
        {
            base.AddObject("Songs", song);
        }
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
        private abstract class GeneratedEdmModel
        {
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
            private static global::Microsoft.OData.Edm.IEdmModel ParsedModel = LoadModelFromString();

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
            private const string filePath = @"biz.dfch.CS.Examples.SampleAspNetCoreWebApiCsdl.xml";

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
            public static global::Microsoft.OData.Edm.IEdmModel GetInstance()
            {
                return ParsedModel;
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
            private static global::Microsoft.OData.Edm.IEdmModel LoadModelFromString()
            {
                global::System.Xml.XmlReader reader = CreateXmlReader();
                try
                {
                    global::System.Collections.Generic.IEnumerable<global::Microsoft.OData.Edm.Validation.EdmError> errors;
                    global::Microsoft.OData.Edm.IEdmModel edmModel;

                    if (!global::Microsoft.OData.Edm.Csdl.CsdlReader.TryParse(reader, false, out edmModel, out errors))
                    {
	                    global::System.Text.StringBuilder errorMessages = new System.Text.StringBuilder();
	                    foreach (var error in errors)
	                    {
		                    errorMessages.Append(error.ErrorMessage);
		                    errorMessages.Append("; ");
	                    }
	                    throw new global::System.InvalidOperationException(errorMessages.ToString());
                    }

                    return edmModel;
                }
                finally
                {
                    ((global::System.IDisposable)(reader)).Dispose();
                }
            }
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
            private static global::System.Xml.XmlReader CreateXmlReader(string edmxToParse)
            {
                return global::System.Xml.XmlReader.Create(new global::System.IO.StringReader(edmxToParse));
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.OData.Client.Design.T4", "#VersionNumber#")]
            private static global::System.Xml.XmlReader CreateXmlReader()
            {
                try
                {
                    var assembly = global::System.Reflection.Assembly.GetExecutingAssembly();
                    var resourcePath = global::System.Linq.Enumerable.Single(assembly.GetManifestResourceNames(), str => str.EndsWith(filePath));
                    global::System.IO.Stream stream = assembly.GetManifestResourceStream(resourcePath);
                    return global::System.Xml.XmlReader.Create(new global::System.IO.StreamReader(stream));
                }
                catch(global::System.Xml.XmlException e)
                {
                    throw new global::System.Xml.XmlException("Failed to create an XmlReader from the stream. Check if the resource exists.", e);
                }
            }
        }
    }
}