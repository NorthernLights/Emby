﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonIO;
using MediaBrowser.Controller.Configuration;
using MediaBrowser.Controller.Entities;
using MediaBrowser.Controller.Library;
using MediaBrowser.Controller.Providers;
using MediaBrowser.Model.Entities;
using MediaBrowser.Model.Logging;
using MediaBrowser.Providers.Manager;

namespace MediaBrowser.Providers.Folders
{
    public class CollectionFolderMetadataService : MetadataService<CollectionFolder, ItemLookupInfo>
    {
        public CollectionFolderMetadataService(IServerConfigurationManager serverConfigurationManager, ILogger logger, IProviderManager providerManager, IProviderRepository providerRepo, IFileSystem fileSystem, IUserDataManager userDataManager, ILibraryManager libraryManager)
            : base(serverConfigurationManager, logger, providerManager, providerRepo, fileSystem, userDataManager, libraryManager)
        {
        }

        protected override void MergeData(MetadataResult<CollectionFolder> source, MetadataResult<CollectionFolder> target, List<MetadataFields> lockedFields, bool replaceData, bool mergeMetadataSettings)
        {
            ProviderUtils.MergeBaseItemData(source, target, lockedFields, replaceData, mergeMetadataSettings);
        }
    }
}
