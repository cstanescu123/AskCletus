import { UserResponse } from "./UserResponse";

export interface UserBarResponse {
    ingredientId: number
    ingredient: string
    userId: number
    user: UserResponse
}

export type PostBar = Omit<UserBarResponse, "ingredientsId">;