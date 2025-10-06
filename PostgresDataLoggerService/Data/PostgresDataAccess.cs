using PostgresDataLoggerService.Data.Interfaces;
using PostgresDataLoggerService.Data.Models;
using PostgresDataLoggerService.Data.Models.Eiva;

namespace PostgresDataLoggerService.Data
{
    public class PostgresDataAccess : IDataWriter, IDataReader
    {
        public Task<bool> ClearSensorsAsync(long nBlockID, bool m_bBathy, bool m_bSingledata, bool m_bDopplerLog, bool m_bGPSHeight, bool m_bGyro, bool m_bMotion, bool m_bPipetracker, bool m_bScan, bool m_bLaser, bool m_bXY, bool m_bAuxiliary)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DBCreateSurveyBlockAsync(double dWindowMinX, double dWindowMaxX, double dWindowMinZ, double dWindowMaxZ, double dGainCalcGyro, bool bUseOnlineSV = false, double dOnlineSVStart = -10, double dOnlineSVEnd = 0, long nBlockId = -1)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DBSaveAlarmAsync(long time, double east, double north, byte src, string type, string alarmtxt, long nBlockId = -1)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DBSaveAuxiliaryAsync(long time, float[] vals, long nBlockId = -1, short seq = 0)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DBSaveBathyAsync(long time, float depth, float altitude = -1, float pressure = -1, long nBlockId = -1, short seq = 0, double m_dScaleDepth = 1)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DBSaveCTDAsync(int type, DateTime time, double east, double north, long nLayers, double[] depth, double[] velo, double[] pres, double[] temp, double[] cond, double[] sali, double[] dens, ref bool blockExist, ref long existingId, long m_nID, List<long> m_CtdBlockIds, List<long> m_SvpBlockIds)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DBSaveCTDLayerAsync(double dDepth, double dVelocity, double dP, double dDens, double dSal, double dCond, double dTemp, long nBlockId = -1)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DBSaveC_OAsync(double gyro, double bathy, double roll, double pitch, double heave, long nBlockId = -1, short seq = 0, double m_dScaleDepth = 1)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DBSaveC_OAsync(ParameterRec param, long nBlockId, short seq)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DBSaveDigitizedLineAsync(double dX, double dY, double dZ, long nCount, long nBlockId = -1)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DBSaveDopplerLogAsync(long time, float vx, float vy, float vz, long nBlockId = -1, short seq = 0)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DBSaveDynOffsetAsync(long time, double dX, double dY, double dZ, double dStdDev, long nBlockId = -1)
        {
            throw new NotImplementedException();
        }

        public Task DBSaveFilterRangeBearingEmptyAsync(int seq, short nType)
        {
            throw new NotImplementedException();
        }

        public Task DBSaveFilterRangeBearingFromVectorAsync(int seq, short type, List<CFilterRangeBearing> m_vInclFilter, List<CFilterRangeBearing> m_vExclFilter)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DBSaveGeodesyAsync(ProjectionInfoType m_projsetup, long nBlockId = -1)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DBSaveGPSHeightAsync(long time, float height, long nBlockId = -1, short seq = 0)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DBSaveGPSStatusAsync(long time, float HDOP, float VDOP, float PDOP, long satNo, long quality, long fixStatus, byte refNo, long nBlockId = -1, short seq = 0)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DBSaveGyroAsync(long time, float heading, float headingCorr = 0, long nBlockId = -1, short seq = 0)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DBSaveHeaveAsync(long time, float heave, long nBlockId = -1, short seq = 0, double m_dScaleDepth = 1)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DBSaveMagnetometerAsync(long time, float mx, float my, float mz, long nBlockId = -1, short seq = 0)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DBSaveMountingAsync(long type, long timeOff = 0, double x = 0, double y = 0, double z = 0, double roll = 0, double pitch = 0, double heading = 0, string name = "", long nBlockId = -1, short seq = 0, short subType = 0, double m_dScaleDepth = 1, double m_dScalePos = 1)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DBSavePipeDiameterAsync(double meters, long nBlockId = -1, long filterBlockId = -1)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DBSavePipetrackerAsync(long time, float x, float z, float[] channels, long quality = -1, long pipeid = 0, float[]? flags = null, long nBlockId = -1, short seq = 0, PipeTrackerInt? extraInt = null, PipeTrackerFloat? extraFloat = null)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DBSavePitchAsync(long time, float pitch, long nBlockId = -1, short seq = 0)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DBSavePositionAsync(long nBlockId, short seq, long time, double east, double north, long[]? pFix, double[]? pKp, double[]? pDal, double[]? pDol, double[]? pRadius, double[]? pDOP, short[]? pQuality, float[]? pStdEast, float[]? pStdNorth)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DBSaveRollAsync(long time, float roll, long nBlockId = -1, short seq = 0)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DBSaveScanAsync(EScanRecord scanData, long time, long nHeadIdx, double soundVelocity, long nDuration = -1, long nPingNumber = -1, long nBlockId = -1, long nDetectionIdx = 0, short nType = 16, int freq = 0, short nNumberOfBeams = 0, byte[]? cBeams = null)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DBSaveScanSectorAsync(ScanSectorRec sectorRecord, long blockId, short headIdx, long relTime, short detectionIdx, short type)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DBSaveSelectedDataSourceAsync(short gyroSeq, short motionSeq, short bathySeq, short speedSeq, short posSeq, short heightSeq, long nBlockId)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DBSaveSelectedMultiSourceAsync(short type, short seq = 0, bool bEnabled = true, long nBlockId = -1)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DBSaveSequenceLinkAsync(int partype, int parseq, int cldtype, int cldseq, long nBlockId = -1)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DBSaveSingleDataAsync(long time, int nEchosounder, double data, long nBlockId = -1, double m_dScaleDepth = 1)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DBSaveSingleDataSpecAsync(int nSpecNumber, long nFlags, long nDataType, long nBlockId = -1)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DBSaveSoundVelocityAsync(string strFileName, DateTime time, long nLayers, double[] depth, double[] velocity, long nBlockId = -1)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DBSaveSoundVelocityLayerAsync(double dDepth, double dVelocity, long nBlockId = -1)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DBSaveSurfacePressureAsync(long time, float pressure, long nBlockId = -1)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DBSaveSurveySettingsAsync(long nBlockId, string strVessel, string strArea, string strJob, string strClient)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DBSaveTideAsync(long time, float tide, long nBlockId = -1, double m_dScaleDepth = 1)
        {
            throw new NotImplementedException();
        }

        public Task FlushBulkObjectsAsync()
        {
            throw new NotImplementedException();
        }

        public Task FlushPositionAsync()
        {
            throw new NotImplementedException();
        }

        public Task FlushSVLayersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<RollDataModel> GetRollAsync(long nBlockId)
        {
            throw new NotImplementedException();
        }

        public Task InitBulkObjectsAsync()
        {
            throw new NotImplementedException();
        }
    }
}
