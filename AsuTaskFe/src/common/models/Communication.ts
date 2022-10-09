export enum CommunicationType {
  NotAsked = 'notAsked',
  Requesting = 'requesting',
  Success = 'success',
  Error = 'error',
}

export interface ICommunication {
  type: CommunicationType;
  error?: string;
}