// Copyright (c) zhenlei520 All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using EInfrastructure.Core.HelpCommon.Systems;
using EInfrastructure.Core.Interface.IOC;
using EInfrastructure.Core.Interface.Log;
using EInfrastructure.Core.Interface.Storage;
using EInfrastructure.Core.Interface.Storage.Param.Pictures;
using EInfrastructure.Core.UCloud.Storage.Config;

namespace EInfrastructure.Core.UCloud.Storage
{
    /// <summary>
    /// 图片服务
    /// </summary>
    public class PictureService : BaseStorageProvider, IPictureService, ISingleInstance
    {
        public PictureService(ILogService logService, UCloudStorageConfig uCloudConfig) : base(logService,
            uCloudConfig)
        {
        }
        
        #region 得到实现类唯一标示

        /// <summary>
        /// 得到实现类唯一标示
        /// </summary>
        /// <returns></returns>
        public string GetIdentify()
        {
            return AssemblyCommon.GetReflectedInfo().Namespace;
        }

        #endregion

        #region 根据图片base64上传

        /// <summary>
        /// 根据图片base64上传
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        public bool Upload(UploadByBase64Param param)
        {
            throw new System.NotImplementedException();
        }

        #endregion

        #region 抓取资源到空间

        /// <summary>
        /// 抓取资源到空间
        /// </summary>
        /// <param name="fetchFileParam">资源信息</param>
        /// <returns></returns>
        public bool FetchFile(FetchFileParam fetchFileParam)
        {
            throw new System.NotImplementedException();
        }

        #endregion
    }
}