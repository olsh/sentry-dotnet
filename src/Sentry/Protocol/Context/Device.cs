using System;
using System.Runtime.Serialization;

// ReSharper disable once CheckNamespace
namespace Sentry.Protocol
{
    /// <summary>
    /// Describes the device that caused the event. This is most appropriate for mobile applications.
    /// </summary>
    /// <seealso href="https://docs.sentry.io/clientdev/interfaces/contexts/"/>
    [DataContract]
    public class Device
    {
        [DataMember(Name = "type", EmitDefaultValue = false)]
        internal const string Type = "device";

        [DataMember(Name = "timezone", EmitDefaultValue = false)]
        private string TimezoneSerializable => Timezone?.Id;

        /// <summary>
        /// The name of the device. This is typically a hostname.
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }
        /// <summary>
        /// The family of the device.
        /// </summary>
        /// <remarks>
        /// This is normally the common part of model names across generations.
        /// </remarks>
        /// <example>
        /// iPhone, Samsung Galaxy
        /// </example>
        [DataMember(Name = "family", EmitDefaultValue = false)]
        public string Family { get; set; }
        /// <summary>
        /// The model name.
        /// </summary>
        /// <example>
        /// Samsung Galaxy S3
        /// </example>
        [DataMember(Name = "model", EmitDefaultValue = false)]
        public string Model { get; set; }
        /// <summary>
        /// An internal hardware revision to identify the device exactly.
        /// </summary>
        [DataMember(Name = "model_id", EmitDefaultValue = false)]
        public string ModelId { get; set; }
        /// <summary>
        /// The CPU architecture.
        /// </summary>
        [DataMember(Name = "arch", EmitDefaultValue = false)]
        public string Architecture { get; set; }
        /// <summary>
        /// If the device has a battery an integer defining the battery level (in the range 0-100).
        /// </summary>
        [DataMember(Name = "battery_level", EmitDefaultValue = false)]
        public short? BatteryLevel { get; set; }
        /// <summary>
        /// This can be a string portrait or landscape to define the orientation of a device.
        /// </summary>
        [DataMember(Name = "orientation", EmitDefaultValue = false)]
        public DeviceOrientation? Orientation { get; set; }
        /// <summary>
        /// A boolean defining whether this device is a simulator or an actual device.
        /// </summary>
        [DataMember(Name = "simulator", EmitDefaultValue = false)]
        public bool? Simulator { get; set; }
        /// <summary>
        /// Total system memory available in bytes.
        /// </summary>
        [DataMember(Name = "memory_size", EmitDefaultValue = false)]
        public long? MemorySize { get; set; }
        /// <summary>
        /// Free system memory in bytes.
        /// </summary>
        [DataMember(Name = "free_memory", EmitDefaultValue = false)]
        public long? FreeMemory { get; set; }
        /// <summary>
        /// Memory usable for the app in bytes.
        /// </summary>
        [DataMember(Name = "usable_memory", EmitDefaultValue = false)]
        public long? UsableMemory { get; set; }
        /// <summary>
        /// Total device storage in bytes.
        /// </summary>
        [DataMember(Name = "storage_size", EmitDefaultValue = false)]
        public long? StorageSize { get; set; }
        /// <summary>
        /// Free device storage in bytes.
        /// </summary>
        [DataMember(Name = "free_storage", EmitDefaultValue = false)]
        public long? FreeStorage { get; set; }
        /// <summary>
        /// Total size of an attached external storage in bytes (e.g.: android SDK card).
        /// </summary>
        [DataMember(Name = "external_storage_size", EmitDefaultValue = false)]
        public long? ExternalStorageSize { get; set; }
        /// <summary>
        /// Free size of an attached external storage in bytes (e.g.: android SDK card).
        /// </summary>
        [DataMember(Name = "external_free_storage", EmitDefaultValue = false)]
        public long? ExternalFreeStorage { get; set; }
        /// <summary>
        /// A formatted UTC timestamp when the system was booted.
        /// </summary>
        /// <example>
        /// 018-02-08T12:52:12Z
        /// </example>
        [DataMember(Name = "boot_time", EmitDefaultValue = false)]
        public DateTimeOffset? BootTime { get; set; }
        /// <summary>
        /// The timezone of the device.
        /// </summary>
        /// <example>
        /// Europe/Vienna
        /// </example>
        public TimeZoneInfo Timezone { get; set; }

        /// <summary>
        /// Clones this instance
        /// </summary>
        /// <returns></returns>
        internal Device Clone()
            => new Device
            {
                Name = Name,
                Architecture = Architecture,
                BatteryLevel = BatteryLevel,
                BootTime = BootTime,
                ExternalFreeStorage = ExternalFreeStorage,
                ExternalStorageSize = ExternalStorageSize,
                Family = Family,
                FreeMemory = FreeMemory,
                FreeStorage = FreeStorage,
                MemorySize = MemorySize,
                Model = Model,
                ModelId = ModelId,
                Orientation = Orientation,
                Simulator = Simulator,
                StorageSize = StorageSize,
                Timezone = Timezone,
                UsableMemory = UsableMemory
            };
    }
}
