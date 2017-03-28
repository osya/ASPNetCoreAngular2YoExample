import { OpaqueToken } from "@angular/core";

export let appConfigOpaqueToken = new OpaqueToken("app.config");

export interface IAppConfig {
}

export const appConfig: IAppConfig = {
};