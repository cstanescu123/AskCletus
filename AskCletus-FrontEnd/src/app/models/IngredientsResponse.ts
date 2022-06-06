import { UserResponse } from "./UserResponse";

export interface IngredientsResponse {
    ingredientsId: number
    ingredient: string
    userId: number
    user: UserResponse
}

export type PostBar = Omit<IngredientsResponse, "ingredientId">;

export type PostIngredientDrinkId = Omit<IngredientsResponse, "ingredientsId" | "user">;