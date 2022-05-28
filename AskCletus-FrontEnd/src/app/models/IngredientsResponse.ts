import { UserResponse } from "./UserResponse";

export interface IngredientsResponse {
    ingredientId: number
    ingredient: string
    userId: number
    user: UserResponse
}

export type PostBar = Omit<IngredientsResponse, "ingredientId">;