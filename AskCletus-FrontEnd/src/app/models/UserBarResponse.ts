import { UserResponse } from "./UserResponse";

export interface UserBarResponse {
    ingredientsId: number
    ingredients: string
    userId: number
    user: UserResponse
}

export type PostBar = Omit<UserBarResponse, "ingredientsId">;