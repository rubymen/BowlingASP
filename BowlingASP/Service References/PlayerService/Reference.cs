﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.33440
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BowlingASP.PlayerService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="player", Namespace="http://schemas.datacontract.org/2004/07/BowlingService.Business")]
    [System.SerializableAttribute()]
    public partial class player : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> Game_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PseudoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private BowlingASP.PlayerService.game gameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<BowlingASP.PlayerService.turn> turnsField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Game_id {
            get {
                return this.Game_idField;
            }
            set {
                if ((this.Game_idField.Equals(value) != true)) {
                    this.Game_idField = value;
                    this.RaisePropertyChanged("Game_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Pseudo {
            get {
                return this.PseudoField;
            }
            set {
                if ((object.ReferenceEquals(this.PseudoField, value) != true)) {
                    this.PseudoField = value;
                    this.RaisePropertyChanged("Pseudo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public BowlingASP.PlayerService.game game {
            get {
                return this.gameField;
            }
            set {
                if ((object.ReferenceEquals(this.gameField, value) != true)) {
                    this.gameField = value;
                    this.RaisePropertyChanged("game");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<BowlingASP.PlayerService.turn> turns {
            get {
                return this.turnsField;
            }
            set {
                if ((object.ReferenceEquals(this.turnsField, value) != true)) {
                    this.turnsField = value;
                    this.RaisePropertyChanged("turns");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="game", Namespace="http://schemas.datacontract.org/2004/07/BowlingService.Business")]
    [System.SerializableAttribute()]
    public partial class game : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> Created_atField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> Lane_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private BowlingASP.PlayerService.lane laneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<BowlingASP.PlayerService.player> playersField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<BowlingASP.PlayerService.turn> turnsField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> Created_at {
            get {
                return this.Created_atField;
            }
            set {
                if ((this.Created_atField.Equals(value) != true)) {
                    this.Created_atField = value;
                    this.RaisePropertyChanged("Created_at");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Lane_id {
            get {
                return this.Lane_idField;
            }
            set {
                if ((this.Lane_idField.Equals(value) != true)) {
                    this.Lane_idField = value;
                    this.RaisePropertyChanged("Lane_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string State {
            get {
                return this.StateField;
            }
            set {
                if ((object.ReferenceEquals(this.StateField, value) != true)) {
                    this.StateField = value;
                    this.RaisePropertyChanged("State");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public BowlingASP.PlayerService.lane lane {
            get {
                return this.laneField;
            }
            set {
                if ((object.ReferenceEquals(this.laneField, value) != true)) {
                    this.laneField = value;
                    this.RaisePropertyChanged("lane");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<BowlingASP.PlayerService.player> players {
            get {
                return this.playersField;
            }
            set {
                if ((object.ReferenceEquals(this.playersField, value) != true)) {
                    this.playersField = value;
                    this.RaisePropertyChanged("players");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<BowlingASP.PlayerService.turn> turns {
            get {
                return this.turnsField;
            }
            set {
                if ((object.ReferenceEquals(this.turnsField, value) != true)) {
                    this.turnsField = value;
                    this.RaisePropertyChanged("turns");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="turn", Namespace="http://schemas.datacontract.org/2004/07/BowlingService.Business")]
    [System.SerializableAttribute()]
    public partial class turn : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> Created_atField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> Game_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> Player_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> ScoreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private BowlingASP.PlayerService.game gameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private BowlingASP.PlayerService.player playerField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<BowlingASP.PlayerService.@throw> throwsField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> Created_at {
            get {
                return this.Created_atField;
            }
            set {
                if ((this.Created_atField.Equals(value) != true)) {
                    this.Created_atField = value;
                    this.RaisePropertyChanged("Created_at");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Game_id {
            get {
                return this.Game_idField;
            }
            set {
                if ((this.Game_idField.Equals(value) != true)) {
                    this.Game_idField = value;
                    this.RaisePropertyChanged("Game_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Player_id {
            get {
                return this.Player_idField;
            }
            set {
                if ((this.Player_idField.Equals(value) != true)) {
                    this.Player_idField = value;
                    this.RaisePropertyChanged("Player_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Score {
            get {
                return this.ScoreField;
            }
            set {
                if ((this.ScoreField.Equals(value) != true)) {
                    this.ScoreField = value;
                    this.RaisePropertyChanged("Score");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public BowlingASP.PlayerService.game game {
            get {
                return this.gameField;
            }
            set {
                if ((object.ReferenceEquals(this.gameField, value) != true)) {
                    this.gameField = value;
                    this.RaisePropertyChanged("game");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public BowlingASP.PlayerService.player player {
            get {
                return this.playerField;
            }
            set {
                if ((object.ReferenceEquals(this.playerField, value) != true)) {
                    this.playerField = value;
                    this.RaisePropertyChanged("player");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<BowlingASP.PlayerService.@throw> throws {
            get {
                return this.throwsField;
            }
            set {
                if ((object.ReferenceEquals(this.throwsField, value) != true)) {
                    this.throwsField = value;
                    this.RaisePropertyChanged("throws");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="lane", Namespace="http://schemas.datacontract.org/2004/07/BowlingService.Business")]
    [System.SerializableAttribute()]
    public partial class lane : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<BowlingASP.PlayerService.game> gamesField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string State {
            get {
                return this.StateField;
            }
            set {
                if ((object.ReferenceEquals(this.StateField, value) != true)) {
                    this.StateField = value;
                    this.RaisePropertyChanged("State");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<BowlingASP.PlayerService.game> games {
            get {
                return this.gamesField;
            }
            set {
                if ((object.ReferenceEquals(this.gamesField, value) != true)) {
                    this.gamesField = value;
                    this.RaisePropertyChanged("games");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="throw", Namespace="http://schemas.datacontract.org/2004/07/BowlingService.Business")]
    [System.SerializableAttribute()]
    public partial class @throw : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> Fallen_skittlesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> Turn_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> numberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private BowlingASP.PlayerService.turn turnField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Fallen_skittles {
            get {
                return this.Fallen_skittlesField;
            }
            set {
                if ((this.Fallen_skittlesField.Equals(value) != true)) {
                    this.Fallen_skittlesField = value;
                    this.RaisePropertyChanged("Fallen_skittles");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Turn_id {
            get {
                return this.Turn_idField;
            }
            set {
                if ((this.Turn_idField.Equals(value) != true)) {
                    this.Turn_idField = value;
                    this.RaisePropertyChanged("Turn_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> number {
            get {
                return this.numberField;
            }
            set {
                if ((this.numberField.Equals(value) != true)) {
                    this.numberField = value;
                    this.RaisePropertyChanged("number");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public BowlingASP.PlayerService.turn turn {
            get {
                return this.turnField;
            }
            set {
                if ((object.ReferenceEquals(this.turnField, value) != true)) {
                    this.turnField = value;
                    this.RaisePropertyChanged("turn");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PlayerService.IServicePlayer")]
    public interface IServicePlayer {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePlayer/createGame", ReplyAction="http://tempuri.org/IServicePlayer/createGameResponse")]
        BowlingASP.PlayerService.game createGame(System.Collections.Generic.List<BowlingASP.PlayerService.player> players);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePlayer/createGame", ReplyAction="http://tempuri.org/IServicePlayer/createGameResponse")]
        System.Threading.Tasks.Task<BowlingASP.PlayerService.game> createGameAsync(System.Collections.Generic.List<BowlingASP.PlayerService.player> players);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePlayer/addPlayer", ReplyAction="http://tempuri.org/IServicePlayer/addPlayerResponse")]
        void addPlayer(BowlingASP.PlayerService.player p, string gId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePlayer/addPlayer", ReplyAction="http://tempuri.org/IServicePlayer/addPlayerResponse")]
        System.Threading.Tasks.Task addPlayerAsync(BowlingASP.PlayerService.player p, string gId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePlayer/deletePlayer", ReplyAction="http://tempuri.org/IServicePlayer/deletePlayerResponse")]
        void deletePlayer(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePlayer/deletePlayer", ReplyAction="http://tempuri.org/IServicePlayer/deletePlayerResponse")]
        System.Threading.Tasks.Task deletePlayerAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePlayer/find", ReplyAction="http://tempuri.org/IServicePlayer/findResponse")]
        BowlingASP.PlayerService.player find(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePlayer/find", ReplyAction="http://tempuri.org/IServicePlayer/findResponse")]
        System.Threading.Tasks.Task<BowlingASP.PlayerService.player> findAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePlayer/findAll", ReplyAction="http://tempuri.org/IServicePlayer/findAllResponse")]
        System.Collections.Generic.List<BowlingASP.PlayerService.player> findAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePlayer/findAll", ReplyAction="http://tempuri.org/IServicePlayer/findAllResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<BowlingASP.PlayerService.player>> findAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePlayer/findGame", ReplyAction="http://tempuri.org/IServicePlayer/findGameResponse")]
        BowlingASP.PlayerService.game findGame(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicePlayer/findGame", ReplyAction="http://tempuri.org/IServicePlayer/findGameResponse")]
        System.Threading.Tasks.Task<BowlingASP.PlayerService.game> findGameAsync(string id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicePlayerChannel : BowlingASP.PlayerService.IServicePlayer, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicePlayerClient : System.ServiceModel.ClientBase<BowlingASP.PlayerService.IServicePlayer>, BowlingASP.PlayerService.IServicePlayer {
        
        public ServicePlayerClient() {
        }
        
        public ServicePlayerClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicePlayerClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicePlayerClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicePlayerClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public BowlingASP.PlayerService.game createGame(System.Collections.Generic.List<BowlingASP.PlayerService.player> players) {
            return base.Channel.createGame(players);
        }
        
        public System.Threading.Tasks.Task<BowlingASP.PlayerService.game> createGameAsync(System.Collections.Generic.List<BowlingASP.PlayerService.player> players) {
            return base.Channel.createGameAsync(players);
        }
        
        public void addPlayer(BowlingASP.PlayerService.player p, string gId) {
            base.Channel.addPlayer(p, gId);
        }
        
        public System.Threading.Tasks.Task addPlayerAsync(BowlingASP.PlayerService.player p, string gId) {
            return base.Channel.addPlayerAsync(p, gId);
        }
        
        public void deletePlayer(string id) {
            base.Channel.deletePlayer(id);
        }
        
        public System.Threading.Tasks.Task deletePlayerAsync(string id) {
            return base.Channel.deletePlayerAsync(id);
        }
        
        public BowlingASP.PlayerService.player find(string id) {
            return base.Channel.find(id);
        }
        
        public System.Threading.Tasks.Task<BowlingASP.PlayerService.player> findAsync(string id) {
            return base.Channel.findAsync(id);
        }
        
        public System.Collections.Generic.List<BowlingASP.PlayerService.player> findAll() {
            return base.Channel.findAll();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<BowlingASP.PlayerService.player>> findAllAsync() {
            return base.Channel.findAllAsync();
        }
        
        public BowlingASP.PlayerService.game findGame(string id) {
            return base.Channel.findGame(id);
        }
        
        public System.Threading.Tasks.Task<BowlingASP.PlayerService.game> findGameAsync(string id) {
            return base.Channel.findGameAsync(id);
        }
    }
}