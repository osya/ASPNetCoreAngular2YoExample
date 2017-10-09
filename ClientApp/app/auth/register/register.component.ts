﻿import { Component, OnInit } from "@angular/core";
import { Router } from "@angular/router";

import { IUser } from "../../models/user.interface";
import { Auth } from ".."
import { Alert } from "../../services/";

@Component({
    selector: "register",
    templateUrl: "./register.component.html"
})
export class RegisterComponent implements OnInit {
    user: IUser;
    loading = false;

    constructor(
        private readonly router: Router,
        private readonly auth: Auth,
        private readonly alert: Alert
    ) { }

    ngOnInit() {
        this.user = {
            email: "",
            password: "",
            confirmPassword: ""
        }
    }

    register() {
        this.loading = true;
        this.auth.signUp(this.user)
            .subscribe(
            () => {
                // set success message and pass true paramater to persist the message after redirecting to the login page
                this.alert.success("Registration successful", true);
                this.router.navigate(["/login"]);
            },
            err => {
                this.alert.error(err);
                this.loading = false;
            });
    }
}